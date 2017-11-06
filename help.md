# Slua 帮助

slua是Unity3D导出为lua的自动化代码生成工具, 通过产生静态的导出代码, 可以不依赖反射的情况大幅度提高运行效率, 优化程度基本与手写导出代码一致, 同时通过小心优化, slua避免了大多数不必要的gc alloc, slua是目前最有效率的Unity3D lua导出解决方案.

## 安装

下载最新版，[这里](https://github.com/pangweiwei/slua/releases/latest), 解压缩，将Assets目录里的所有内容复制到你的工程中，对于最终产品，可以删除Resourece，例子，文档等内容，只保留Plugins目录，如果是开发阶段则无所谓。

等待unity编译完毕，如果一切顺利的话，将出现slua菜单， 点击slua菜单中 All->Make 命令 手动生成针对当前版本的U3d接口文件。

***每次更新slua版本，务必记得clear all，然后make all，否则可能运行不正确***



## 导出接口

### 自动导出

slua会自动导出UnityEngine的大部分接口, 导出UnityEngine.UI( 需要Unity3d 4.6+ )的全部接口(不需要可以删除) 这只需要通过点击Slua 菜单Make 和 Make UI命令,就会自动产生对应的接口文件, 你可能会发现一些UnityEngine的接口并没有导出, 被忽略的接口主要是平台相关,或者极少没用到的接口, 如果这些接口你也需要导出, 请手动修改代码 CustomExport.cs 文件 的 OnGetNoUseList 函数， 返回 noUseList列表, 这个列表写明了哪些接口不需要导出, 考虑到实际游戏开发过程中可能不需要用到那么多接口, 在实际发布的游戏中, 可以仅保留需要的接口, 这样生成的代码会更小. 

**自动导出会导出几乎全部unityengine接口，这会在启动的时候浪费巨大的时间去绑定lua接口，在生产环境使用，建议根据需要，仅导出需要使用的接口，避免启动时浪费时间，默认的demo main是导出全部接口，可以参考下全部导出时需要的绑定时间，注意左上角的百分比进度**


同时有部分接口可能在移动平台上不存在, 这导致在发布移动平台的时候报告找不到接口的错误, 所以默认slua已经将4.6.1中遇到的这部分接口也屏蔽了, 在未来的版本中可能遇到更多类似接口, 你仅需要将对应的接口加入 memberFilter 列表（在LuaCodeGen.cs文件，未来可能移动到CustomExport文件内）, 重新Make即可(注意重新Make时需要保证没有编译错误, 可以用Clear All删除全部导出文件), 例如:  
​    
```csharp
    static List<string> memberFilter = new List<string>
    {
        "AnimationClip.averageDuration",
        "AnimationClip.averageAngularSpeed",
        "AnimationClip.averageSpeed",
        "AnimationClip.apparentSpeed",
        "AnimationClip.isLooping",
        "AnimationClip.isAnimatorMotion",
        "AnimationClip.isHumanMotion",
        "AnimatorOverrideController.PerformOverrideClipListCleanup",
        "Caching.SetNoBackupFlag",
        "Caching.ResetNoBackupFlag",
        "Light.areaSize",
        "Security.GetChainOfTrustValue",
        "Texture2D.alphaIsTransparency",
        "WWW.movie",
        "WebCamTexture.MarkNonReadable",
        "WebCamTexture.isReadable",
    };
```

### 手动导出

slua支持手动导出任何自定义接口, 为此你仅需要将对应的类加入CustomExport OnAddCustomClass() 函数的 list列表里, 例如:

```csharp
    public static void OnAddCustomClass(ref List<Type> list)
    {
        list.Add(typeof(System.Func<int>));
        list.Add(typeof(System.Action<int,string>));
        list.Add(typeof(System.Action<int, Dictionary<int, object>>));
        // add your custom class here
    }
```

也可以通过给类增加[CustomLuaClassAttribute]属性来标记需要导出的类, 而不需要添加代码到上面的List列表, 感谢@luzexi提交了这个便捷的功能, 例如:

```csharp
    [CustomLuaClassAttribute]
    public class Custom : MonoBehaviour {
    ...
    }
```

这样会导出Custom类.

如果类型有基类,并且需要在lua中访问基类成员, 也需要导出基类, 如果基类是系统自带类或者第三方库类(不方便修改添加CustomLuaClassAttribute标签), 则可以使用第一种方法, 手动添加到导出列表.

在自定义的类中, 所有public 成员方法/静态方法/属性/数据成员都会导出.

如果对应的类型中, 存在 public 的 代理的属性/数据成员, 会自动加入导出, 否则需要手动加入上面List, 否则可能在运行是找不到对应的接口报错, 例如:

```csharp
    public SomeDelegate someDelegate;
```

会自动产生对应的导出代码, 但如果该代理为函数参数被使用, 则不会自动导出, 需要手动添加.


#### 自定义方法

任何具有[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]属性的static public方法, 都会尝试导出为自定义方法, 而不产生对应的包装方法, 例如 如下函数:

```csharp
    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static public int instanceCustom(IntPtr l) {
        Custom self = (Custom)LuaObject.checkSelf(l);
        LuaObject.pushValue(l, true);
        LuaDLL.lua_pushstring(l,"xiaoming");
        LuaDLL.lua_pushstring(l,"hanmeimei");
        LuaDLL.lua_pushinteger(l,self.v);
        return 4;
    }
```

仅仅自动注册到对应的lua接口里,不产生对应的包装方法再包装这个函数, 这使得你可以实现自己的任何lua函数, 用于自定义导出, 比如返回多个返回值. 注意 LuaObject.pushValue(l, true) 这行，表示这个lua导出函数是否成功，如果返回true表示没有报错，false则表示有报错，但是这个返回值在lua里并拿不到，而是被内部函数用于检查函数成功与否而“吃掉”了，所以上述的函数只能拿到3个返回值。

在默认情况下, 上面的函数产生的是成员方法, 即它需要接受一个self的ud, 在lua层面需要 self:instanceCustom 的方式调用, 如果你需要个静态方法, 需要多加一个[StaticExport], 例如:

```csharp
    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    [StaticExport]
    static public int staticCustom(IntPtr l) {
    	LuaObject.pushValue(l, true);
        LuaDLL.lua_pushstring(l,vs);
        LuaObject.pushObject(l, c);
        return 3;
    }
```

#### 指定不导出

对于某些public的成员, 可能并不需要导出, 导出对于lua也没有意义, 这个时候你可以添加[DoNotToLua]属性, 指定此成员不需要导出到lua,  例如:

```csharp
    [DoNotToLua]
    static public void dontexport()
    {
    }
    [DoNotToLua]
    public int a;
    [DoNotToLua]
    public int A
    {
        get
        {
            return a;
        }
    }
```

以上方法, 数据, 属性都不会导出. 如果仅用于内部成员访问, 可以考虑使用internal可见性, 这样既能保证自己的代码可以访问到成员, 又不必添加[DoNotToLua]属性, 还能控制其不导出, 所以更推荐的做法是使用internal关键字.

#### 同名重载方法

slua支持同名重载方法, 但对于自己实现的接口(非来自UnityEngine), 不建议采用同名重载方法, 因为这样会降低slua的运行效率, 因为它比不同名的方法多一步参数匹配的过程, 同时重载方法的参数匹配不能严格区别参数的类型(主要是因为lua的类型少于c#),所以导致部分同名的重载工作不正常，也可以考虑使用下面的LuaOverrideAttribute单独制定函数名字，避免不必要的重载检查。

#### 使用LuaOverrideAttribute

如果不可避免的存在重载函数，又希望lua里可以确定的使用某一个版本的重载，可以使用LuaOverrideAttribute，例如

```csharp
	static public void AFunc(int a) {
		Debug.Log ("AFunc with int");
	}

	static public void AFunc(float a) {
		Debug.Log ("AFunc with float");
	}

	static public void AFunc(string a) {
		Debug.Log ("AFunc with string");
	}

	[LuaOverride("AFuncByDouble")]
	static public void AFunc(double a) {
		Debug.Log ("AFunc with double");
	}
```

这样便会产生一个AFuncByDouble的独立导出函数，专门针对double类型的AFunc。


#### 重载导出类的方法

有时我们需要在默认动态生成的导出函数中增加一些自己的代码，之前你需要在生成的wrapper文件里手动添加对应的代码，但这样每次重新make之后，添加的代码会丢失，需要重新添加，这时你可以考虑重载默认的导出方法，例如：

```csharp
namespace SLua {
	
	[OverloadLuaClass(typeof(GameObject))]
	public class MyGameObject : LuaObject {
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		public static int Find_s(IntPtr l) {
			UnityEngine.Debug.Log ("GameObject.Find overloaded my MyGameObject.Find");
			try {
				System.String a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.GameObject.Find(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			catch(Exception e) {
				return error(l,e);
			}
		}
	}

}
```

这样GameObject.Find方法的导出方法会调用到上面Find_s函数中，你可以任意添加自己的代码，在最终的wrapper文件中，也会使用上述方法作为Find方法的导出实现。

#### 可变参数方法调用

在c#里有params类型的可变参数调用, slua同样支持, 例如:

```csharp
    static public void func6(string str, params object[] args)
    {
        Debug.Log(str);
        for (int n = 0; n < args.Length; n++)
        {
            Debug.Log(args[n]);
        }
    }
```

需要注意的是, 可变参数函数不支持任何同名重载, 并且params修饰符必须针对最后一个参数.


#### out参数

out参数是c#特有的语法,lua并不支持out参数,为此此slua采用多返回值来处理out参数,即所有out的参数都会变成一个返回值, 例如:
​    
```lua
    -- get out parameter
    local ok,hitinfo = Physics.Raycast(Vector3(0,0,0),Vector3(0,0,1),Slua.out)
    print("Physics Hitinfo",ok,hitinfo)
```

将Slua.out作为out参数传入Raycast函数,然后通过返回值返回.


##### Type参数

在slua里,基于效率和易用性的原则, 不建议导出System空间下的类型, 而使用变通方法来表达类似需求, 对于Type参数的传入, 对于导出类型,比如UnityEngine.GameObject, HelloWorld等,可以直接使用对应的lua table来当作参数传入, 在c#会理解为Type, 例如:

```lua
    HelloWorld.ofunc(GameObject)
```

在c#端,有对应函数:

```csharp
    static public void ofunc(Type t) {
        Debug.Log(t.Name);
    }
```


从Unity5开始AddComponent不再支持字符串作为类型参数, 可以使用上面的方面传递类型.

对于没有导出的Type,原则上可以使用字符串来描述, 例如:

```lua
    HelloWorld.ofunc("UnityEngine.GameObject,UnityEngine")
```


当作Type传入的string需要符合c#的描述规则，请参考Type.GetType方法的帮助，获得如何通过字符串描述type。

但目前采用同Type做为参数的方法如果存在重载方法, 则可能工作不正常, 建议避免使用同名重载.


#### 类型转换

正常使用情况，一般不会在lua层面做类型转换，因为所有的对象到了lua里都是userdata，在c#层面维护了一张表保存每个userdata的类型，在少数情况下需要downcast为子类的时候，需要在lua层面转换c#的数据类型，可以使用As方法，例如：

```lua
    local v = CreateBase() -- 返回BaseObject
    local x = Slua.As(v,Child) -- Child继承自Base
```

这样将会把userdata v的metatable ChildObject，这意味着你可以在lua层面调用ChildObject的方法。


#### 代理(delegate)

slua支持直接使用代理, 仅需要传入lua function, 这大大方便开发工作, 例如, 存在如下代理:

```csharp
    public delegate bool GetBundleInfoDelegate(string path, out string url);
    public GetBundleInfoDelegate d;
```

在lua端, 代码如下:

```lua
    xxx.d=function(path)
        return true,url
    end
```

这样就完成了代理对象的设置, 同时注意out修饰符的url参数, 因为lua没有对应的机制, 如果需要返回url参数需要lua按顺序返回多个参数.

slua的delegate支持+=/-=操作, 例如

```lua
    self={}
    function self.xxx(a,b,c)
	// code
    end
    h.d={"+=",self.xxx}
	h.d={"-=",self.xxx}
```

上面的例子演示了, 如何在回调函数内使用self, 同时演示了如果+=/-= 代理函数

同时System.Action<>/System.Func<> 这种泛型代理也支持, slua会自动将遇到的泛型参数展开, 例如:

```csharp
    public static Action<int, Dictionary<int, object>> daction;
```

## Coroutine(Yield)

Slua支持unity yield指令,  需要配和lua coroutine, 例如:

```lua
    local c=coroutine.create(function()
		print "coroutine start"
		Yield(WaitForSeconds(2))
		print "coroutine WaitForSeconds 2"
		local www = WWW("http://www.sineysoft.com")
		Yield(www)
		print(www.bytes)
		print(#www.bytes)
	end)
    coroutine.resume(c)
```

在lua coroutine内使用Yield函数,可以中断当前运行的coroutine,直到yield的对象完成操作才会继续回来执行下面的代码. 注意, Yield函数不能在主线程(main coroutine)调用.

## LuaVarObject

当返回一个没有导出的类型时, slua将自动返回一个表示LuaVarObject的userdata, 通过LuaVarObject, 你任然可以访问没有导出的类的方法和成员, 但LuaVarObject使用的反射的方法来访问, 这在slua中是非常不推荐的, 这将显著降低slua运行的效率, 对于频繁使用的类型请导出它们再使用,但对于某些场合,使用LuaVarObject还是很方便的, 这包括:

1) 你希望将一个没有导出的类, 在lua层面仅作为函数参数传递, 而不在lua中调用其方法/成员;

2) 你非频繁的使用某些泛型类, 例如:

```csharp
    public Dictionary<string, GameObject> foo()
    {
        return new Dictionary<string, GameObject>();
    }
```

其中Dicionary<string,GameObject>并没有导出,但你可以在lua中调用其方法, 例如:

```lua
    local dict = obj:foo()
	for i=1,10 do
		dict:Add(tostring(i),GameObject("dict"..i)) -- add k,v to Dictionary<string,GameObject>
	end
    dict["hello"] = GameObject("world")
    print("Dict count",dict.Count)
```

但请记住,上面的访问过程都是经过反射操作来完成的,速度不理想,应该避免在频繁运行的代码中使用给他们.

最后, ***LuaVarObject并没有完善, 仅满足最低使用需求, 如果你发现有任何bug, 需要自行完善他们, 作者欢迎你完善后提交pull request合并到slua主分支, 让你的代码成为slua的一部分.***

## 创建未导出的类

对于一个没有导出的类,slua不建议直接拿来使用(因为效率问题,并严重不推荐在最终产品中使用),但某些情况下临时使用方便开发调试, 为此你可以使用CreateClass函数来创建未导出的类, 例如

```lua
    -- create class used reflection
	local go=Slua.CreateClass("UnityEngine.GameObject,UnityEngine","VarGameObject")
	print(go.name)
	local array=Slua.CreateClass("System.Collections.ArrayList",10)
	print(array.Capacity)
	array:Add("slua")
	array:Add("unity")
	print(array.Count,array[0],array[1])
```

#### CreateClass(type,args...) -> obj

type参数为需要创建类的字符串描述,关于一个类的字符串描述,可以参考msdn上Type.Get方法的说明.

args参数为类构造函数的传入参数

如果一切正常将返回对应的类对象.


### GetClass(type) -> class

如果不像构造类，只是想得到类，并调用他的static方法，可以使用GetClass返回类对象. 例如

```lua
    -- get class used reflection
	local h=Slua.GetClass("HelloWorld")
	print(h.getNegInt())
```


## LuaTimer

LuaTimer用于在限定时间周期性的回调lua函数, 强烈建议不要使用系统自带timer, slua timer会在lua虚拟机被关闭后停止timer工作,而一般系统自带timer可能会在lua虚拟机被关闭后任然触发timer,导致调用lua函数失败,从而产生闪退等.

### Add(delay,func) -> id

增加一个一次性Timer, timer在delay时间后触发, 单位ms.

### Add(delay,cycle,func) -> id

增加一个Timer, delay表示延迟时间,单位ms, cycle表示周期时间,单位ms, func为回调的lua函数, Add函数返回一个timer id,用于Delete函数删除某个已经添加的Timer, 例如:

```lua
        LuaTimer.Add(0,20,function(id)
		cube.transform.localScale = Vector3(10,10,10)*(0.1+math.sin(os.clock()))
		cube2.transform.position = Vector3(math.sin(os.clock())*5,0,0)
		return true
	end)
```

添加一个立刻开始,20ms回调一次的Timer,回调函数的id参数表示该timer的id, 如果需要持续回调返回true,返回false或者没有返回值, 表示该回调仅执行一次.

### Delete(id)

删除指定id的timer.


## 在lua中继承c#的基类

slua支持直接在lua中继承扩展c#的基类,例如:

```lua
    MyVector3=Slua.Class(Vector3,
	nil, --static function
	{ --instance member function
		Normalize=function(self)
			print "overloaded Normalize"
			local l=math.sqrt(self.x*self.x+self.y*self.y,self.z*self.z)
			self.x=self.x/l
			self.y=self.y/l
			self.z=self.z/l
		end,
		Set=function(self,x,y,z)
			self.__base:Set(x,y,z)
		end,
	}
    )
```

在成员函数中,可以使用self.__base调用基类的成员方法.

## 在lua中遍历IEnumertable对象

c#中使用foreach语句遍历IEnumertable,例如List,Array等, 在slua中,可以使用Slua.iter作为迭代函数遍历这些对象, 例如:

```lua
    for t in Slua.iter(Canvas.transform) do
		print("foreach transorm",t)
    end
```

返回的t是Canvas.transform的一级子对象.



## C#的数组

之前的slua会将T[]的数组转换为lua table在lua内使用，这样的好处是可以用lua原生语言特性来使用T[]，这在数组数据长度小的时候是一个不错的选择，但当数组长度变大的时候，则有很大的数据拷贝的消耗，在1.3之后，slua不在默认转换为lua table，而是使用LuaArray这样的userdata来出来数组，这样在push数组到lua的时候不再有额外开销，而当你使用的时候，LuaArray提供必要的方法帮助你访问对应的数据，例如：

```lua
local array = SomeFunctionReturnArray() --假设存在某个方法返回int[]
print(array.Length,#array) --返回数组长度
for i=0,array.Lenght-1 do
  print(i,array[i]) --访问array数据，下表从0开始
end
local t = array.Table --转换为lua table
for i,v in ipairs(t) do
  print(i,v) --访问table数据，下表从1 开始
end
array[0]=1024 --设置
```

## C#的字节数组

byte[]是T[]的特殊形式，一般用于内存字节流，比如网络字节流，之前的slua是把byte[]转换为string来处理，但自己推销这样的转换也有数据复制的开销，同时用string来读取字节流并不方面，为此slua提供ByteArray类支持byte[]，同时提供多样的read、write方法来存取字节流，例如：

```lua
	-- bytes return byte[]
	local data = HelloWorld.bytes()
	data[1]=11
	print("data type ",type(data),#data,data.Table[1],data,data[1],data[2])

	-- test bytearray object wity array
	local ba = Slua.ByteArray(data)

	data = Slua.ToString(data)
	print("data type ",type(data),data)


	print('Construct bytearray object',ba)
	print(ba:ReadByte(),ba:ReadByte())
	assert(ba.Length==4)
	assert(ba.Position==2)
	assert(ba:ReadByte()==53)

	-- construct new byte array
	local ba = Slua.ByteArray()
	ba:WriteByte(11)
	ba:WriteByte(22)
	ba:WriteVarInt(1024)
	ba:WriteShort(5656)
	ba:WriteNum(3.1415)
	ba.Position=0
	assert(ba:ReadByte()==11)
	assert(ba:ReadByte()==22)
	assert(ba:ReadVarInt()==1024)
	assert(ba:ReadShort()==5656)
	assert(ba:ReadDouble()==3.1415)
```

新版本推荐使用ByteArray来处理byte[]，如果你仍然想当做string来处理可以使用Slua.ToString将byte[]转换为string。

## 判断GameObject是否为null

因为Unity GameObject被destroy后，并不是真正的null，而是一个被标记了为destroyed的GameObject，而GameObject重载了==操作符，在c#中可以==判断是否为null（虽然它不是null），而这个gameobject被push到lua后，并不能判断==nil，所以slua提供IsNuall函数，用于判断是否GameObject被Destory，或者GetComponent的返回值其实不存在，也可以通过IsNull判断，例如：

```lua
    local go = GameObject()
    local comp=go.GetComponent(SomeNotExistsComponent)
    Slua.IsNull(comp) --true
    GameObject.Destroy(go)
    Slua.IsNull(go) -- true
```



## LuaObject快速释放

push进入lua虚拟机的c#对象都是LuaObject，需要等待lua gc回收后，才能触发c#侧删除对应引用，然后等待c# gc才能真正删除对应对象占用的内存，这个过程一般情况下不用操心，slua已经经过非常广泛的测试和线上产品使用，不存在内存泄露。但有时我们可以保证lua脚本处不在使用c#对象，希望它能尽快被释放，我们可以这么做：

1）保证所有对象引用的变量都置空；

2）调用collectgarbage("collect")，这样将加快lua回收的速度，但不能保证所有置空的变量都一定被回收；

3）调用c#侧GC.Collect()方法，同上，这样将加快c#对象回收速度

4）任何LuaObject都提供一个Unlink方法，这个方法将断开c#和lua的映射关系，相当于在c#侧移除了对象引用，不管lua侧是否还会继续使用，如果lua后续继续使用这个LuaObject将会报错误，使用这个方法可以跳过1-2步骤，只要c#能触发gc，这个对象就会被释放，同时lua脚本自己要保证调用这个方法不会出现继续使用的可能。

## 如何快速导出第三方库, 例如ngui等

新建一个空工程,将第三方库的所有代码放入Assets内, 等待Unity编译完成;
打开产生的sln工程,找到 Assembly-CSharp 工程, 修改工程"程序集名称"由Assembly-CSharp改为第三方库名称,例如NGUI;
选择目标框架为".net Subset Base class Libraries";
调整为Release版本, 然后生成对应的dll;
将dll放入Assets目录;
打开CustomExport.cs, 找到OnAddCustomAssembly() 函数

在List内添加程序集名字, 例如:

```csharp
    list.Add("NGUI");
```

保存, 等待编译完成, 点击Make custom,将会生成NGUI的全部接口文件,将产生的wrap文件复制到游戏工程内的Slua/LuaObject/custom内,

**注意去掉对UnityEditor的引用，否则发布的时候可能失败, 因为手机环境下没有UnityEditor的运行环境**

然后删除DLL,该DLL仅用于快捷生成wrap文件, 还需要ngui代码放在Assets目录内, 因为其有部分editor功能代码,需要在editor内运行.

## 从c#调用lua函数

从c#调用lua函数，需要先从luastate内获得对应lua函数，一般是通过在luastate或者luatable内直接通过[]返回对应key的函数，例如：

```csharp
public class Circle : MonoBehaviour {


	LuaSvr svr;
	LuaTable self;
	LuaFunction update;

	void Start () {
		svr = new LuaSvr();
		svr.init(null, () =>
		{
			self = (LuaTable)svr.start("circle/circle");
            update = (LuaFunction)self["update"] ;
		});
	}
}
```

拿到luafunction后可以直接调用成员方法call，并传入参数，例如：

```csharp
	void Update () {
		if(update!=null) update.call(self);
	}
```
但使用上述方法传递参数可能导致额外gc alloc的开销，例如参数是valuetype，或者primitive type（例如int，float）都会有box、unbox的gc alloc风险，这个时候，可以考虑导出对应delegate，并转换luafunction为对应的delegate，就可以避免gc alloc开销，提高调用速度，例如：

```csharp
public class Circle : MonoBehaviour {


	LuaSvr svr;
	LuaTable self;
	LuaFunction update;

    [CustomLuaClass]
    public delegate void UpdateDelegate(object self);

    UpdateDelegate ud;

	void Start () {
		svr = new LuaSvr();
		svr.init(null, () =>
		{
			self = (LuaTable)svr.start("circle/circle");
            update = (LuaFunction)self["update"] ;
            ud = update.cast<UpdateDelegate>();
		});
	}
	
	void Update () {
        if (ud != null) ud(self);
	}
}
```

注意[CustomLuaClass]标记，通过这个标记可以导出UpdateDelegate，如果你忘记了这个标记，cast将失败并返回null。

## 多LuaState实例

一般情况下整个游戏只需要一个luastate，整个luastate与游戏app有着相同的生存周期，但有些情况下，为了隔离不同的业务逻辑，需要多个state，各自处理不同业务逻辑，各自有不同的生命周期，这个时候可以使用从slua1.5开始支持的多LuaState，可以参考MultiState的再带demo，例如：

```csharp
public class MultiState : MonoBehaviour {

	LuaSvr svr;
	LuaState[] ls=new LuaState[10];
    LuaFunction update;
    LuaTable self;
	// Use this for initialization
	void Start () {
		svr = new LuaSvr (); // main state
		svr.init (null, complete); 
	}

	void complete() {
		// create 10 lua state
		for (int n = 0; n < 10; n++) {
			ls[n] = new LuaState (); // 额外创建更多的state

            ls[n].Name = (string.Format("LuaState {0}", n));
			ls[n].doString (string.Format ("print('this is #{0} lua state')", n));

			ls[n].openSluaLib();
			ls[n].doString(@"
            local n=0 
            LuaTimer.Add(0,1000,
                function() print('timer print '..tostring(n)) 
                n=n+1
                return true 
            end)");
		}
        ls[0].bindUnity();

        ls[0].doFile("circle/circle");
        self = (LuaTable)ls[0].run("main");
		update = (LuaFunction)self["update"];
	}
	
	// Update is called once per frame
	void Update () {
		if (update != null) update.call(self);
	}

	void OnDestroy() {
		for (int n = 0; n < 10; n++) {
            if(ls[n]!=null)
			    ls [n].Dispose ();
		}
	}
}
```



## 编译bytecode

slua 1.5后所有平台统一使用luajit作为lua虚拟机，lua代码可以被luajit编译为bytecode发布，使用bytecode可以很好的保护你的lua代码，目前没有针对luajit有效反编译工具可以查看原始lua代码。如果你想发布bytecode，仅需要针对目标平台，点击slua->Compile Bytecode菜单即可。

目前分为3个目标，分别为

luajitx86，针对win32和android、iOS armv7平台

luajitx64，针对x64

luajitgc64，针对mac64, iOS arm64，Android arm64平台



默认slua会将Assets/Slua/Resources/*.txt当做lua脚本文件进行编译，并输出到Assets/jit/目录下，如果你有需要编译其他位置的lua文件，可以参考Editor/LuajitGen.cs文件，修改对应目标位置。

Bytecode与目标设备的cpu有关，需要针对iOS和android各生成arm v7和arm 64两个版本才能在android和iOS的32、64位系统上跑起来，所以在最终发布版本中，需要同时包含2种bytecode，然后根据判断平台类型，针对性的读取，或者将代码部署在云端，根据平台针对性下载对应bytecode的压缩包。

在Unity编辑器下，可以通过打开setting面板，切换读取jit bytecode的格式，默认是None，读取lua源代码，你可以切换为x86则是在win unity 4.x上测试bytecode，x64则是win（64bit） unity5.x上测试bytecode，gc64则是Mac osx上测试。



## Lua控制台

slua附带一个lua控制台，用于在编辑器内交互式调试，你可以控制台内输出任何合法的lua语句，回车后可以立刻运行对应语句，并查看结果，启动lua控制台的方法，是点击slua->LuaConsole 菜单，熟练使用控制台，可以帮助你快速定位、调试问题。



## 编译lua接口文件

slua会生成很多绑定接口文件，一般他们在Slua/LuaObject目录下，你每次修改cs代码，都会导致全部cs代码重新编译，当存在大量接口文件时，这个编译时间比较长，为此你可以将slua生成的接口文件编译为一个dll，这样接口文件就不需要每次重新编译，加速cs代码修改后的编译时间，为此你可以直接点击slua->compile luaobject to dll菜单，如果一切顺利，会在LuaObject下生成一个sluaWrapper.dll文件，以后你就不必每次都编译接口文件了，如果你修改了导出接口，需要重新make，也可以直接点make菜单，这时会删除sluaWrapper.dll，并重新生成全部接口文件。



## 远程调试

[远程调试](https://github.com/pangweiwei/slua/wiki/%E8%BF%9C%E7%A8%8B%E8%B0%83%E8%AF%95)


## 编译slua库

在build目录下，已经集成了win/macosx/android/ios的编译脚本，其中macosx/android/ios编译脚本推荐在macosx系统下编译，win平台需要vs2012/vs2013，通过运行这些编译脚本，可以直接生成slua library.



## 使用Lua5.3

slua默认使用luajit作为lua虚拟机，目前（1.5版）使用的是luajit-2.1-beta3，同时slua支持使用lua5.3，使用lua5.3有一些优势，比如支持int64，utf8支持的更好，但lua5.3并不如luajit运行速度快，所以是否切换为lua5.3需要用户自己权衡。

如果你想采用lua5.3，需要在UnityEditor的PlayerSetting内加入LUA\_5\_3的宏，同时需要自己编译lua5.3的运行库，目前slua build没有默认提供lua5.3的运行库，这需要你自己修改编译脚本，编译对应的5.3的库，未来slua可能默认提供lua5.3的编译支持，将编译的slua运行库放入Unity Plugins目录内（包含win、mac、android、iOS、linux平台），然后重启Unity，就可以使用lua5.3作为lua虚拟机了。



如果是设置了  LUA\_5\_3 的宏，但没有切换运行库，或者切换了运行库，没有 增加LUA\_5\_3宏，都会导致启动的时候crash，务必注意。



最后你可以参考 https://github.com/yaukeywang/slua-503-build 这个lua5.3的repo，该repo完成了编译lua5.3的功能，可以直接使用，详细构建过程，可以参考 http://www.cnblogs.com/yaukey/p/slua-530-compile-project.html 。



## Standalone 运行

一般情况下，slua是在Unity环境下使用，用于使用lua语言开发客户端逻辑，但slua同样支持基于mono（c#）环境开发服务器，我们把这种运行模式叫做Standalone模式，在Standalone模式下不依赖任何Unity的dll，仅依赖mono，这样就可以在mono下使用c#开发服务器，使用lua作为脚本语言实现服务器逻辑。

下面我们介绍一下如何完成一个最简单的Standalone的demo，在slua目录下，进入Standalone目录，

```shell
$ sh premake.sh
```

这样将会生成对应平台的make文件，用于编译standalone的dll和对应demo，然后进入gmake目录

```shell
$ make
```

这样将会编译dll和demo，如果一切正常将会 ../bin目录下生成slue-standalone.dll, slua-standalone-tests.dll和slue-standalone-demo.exe 。demo的代码如下：

```csharp
using System;
using SLua;


public class Demo
{
    private LuaSvr luaSvr;

    static public void Main() {
        Demo demo = new Demo();
        demo.Init();   
    }
        
    public void Init()
    {
        luaSvr = new LuaSvr();
        luaSvr.init(null,onComplete);
    }
    void onComplete() {
        Console.WriteLine("complete");
        string txt=@"
        local a=1
        local b=2
        print('result',a+b)
        ";
        LuaSvr.mainState.doString(txt);
    }
}
```



然后回到Standalone目录，

```shell
$ mono --config slua-standalone.dll.config bin/slua-standalone-demo.exe
complete
result    3
```

 这样就可以运行slua-standalone-demo.exe了，注意--config slua-standalone.dll.config用于配置mono加载dll的搜索方式，如果配置不正确，会报告找不到slua库的运行时错误，具体可以参考mono的文档。



## 常见问题


[常见问题](https://github.com/pangweiwei/slua/wiki/%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98)


## 已知问题

部分同名重载参数类型检查可能会失败(因为lua的类型少于c#), 建议手写代码避免同名重载, 这样效率也更高，或者建议使用LuaOverrideAttribute.

返回没有导出的类型, 会采用LuaVarObject, 这个类退化为使用反射, 并且并没有完善, 不建议返回没有导出的类, 简单例子可以参考varobj工程.

函数的默认参数不支持.

问题补充：[见test.cs]:
* 不支持Nullable. (TestNullable)
* 不支持跨线程调用LuaState. (TestThreading)
* 不支持父类方法重载. (TestCallImplicitBaseMethod)
* 不支持读Action. (TestPushLuaFunctionWhenReadingDelegateProperty)
