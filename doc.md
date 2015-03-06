#Slua 帮助

slua是Unity3D导出为lua的自动化代码生成工具, 通过产生静态的导出代码, 可以不依赖反射的情况大幅度提高运行效率, 优化程度基本与手写导出代码一致, 同时通过小心优化, slua避免了大多数不必要的gc alloc, slua是目前最有效率的Unity3D lua导出解决方案.

##安装

通过git clone复制一份代码到你的资源目录(Assets目录内), slua的发布版已经附带了Unity3D 4.6.1 的导出接口文件, 在Slua/LuaObject内, 对于其他版本(比如5.0), 你可以删除该目录内所有文件, 等待脚本编译完成, 点击slua菜单中 Make 命令 手动生成针对当前版本的U3d接口文件, 如果你运行例子代码产生错误,记得要make ui,make custom,保证例子中使用到的接口都被导出了.



##导出接口

###自动导出

slua会自动导出UnityEngine的大部分接口, 导出UnityEngine.UI( 需要Unity3d 4.6+ )的全部接口(不需要可以删除) 这只需要通过点击Slua 菜单Make 和 Make UI命令,就会自动产生对应的接口文件, 你可能会发现一些UnityEngine的接口并没有导出, 被忽略的接口主要是平台相关,或者极少没用到的接口, 如果这些接口你也需要导出, 请手动修改代码 LuaCodeGen.cs 文件 的noUseList列表, 这个列表写明了那些接口不需要导出, 考虑到实际游戏开发过程中可能不需要用到那么多接口, 在实际发布的游戏中, 可以仅保留需要的接口, 这样生成的代码会更小. 


同时有部分接口可能在移动平台上不存在, 这导致在发布移动平台的时候报告找不到接口的错误, 所以默认slua已经将4.6.1中遇到的这部分接口也屏蔽了, 在未来的版本中可能遇到更多类似接口, 你仅需要将对应的接口加入 memberFilter 列表, 重新Make即可(注意重新Make时需要保证没有编译错误, 可以用Clear All删除全部导出文件), 例如:  
>     static List<string> memberFilter = new List<string>
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


###手动导出

slua支持手动导出任何自定义接口, 为此你仅需要将对应的类加入CustomExport OnAddCustomClass() 函数的 list列表里, 例如:
>     public static void OnAddCustomClass(ref List<Type> list)
    {
        list.Add(typeof(System.Func<int>));
        list.Add(typeof(System.Action<int,string>));
        list.Add(typeof(System.Action<int, Dictionary<int, object>>));
        // add your custom class here
    }

也可以通过给类增加[CustomLuaClassAttribute]属性来标记需要导出的类, 而不需要添加代码到上面的List列表, 感谢@luzexi提交了这个便捷的功能, 例如:

>     [CustomLuaClassAttribute]
    public class Custom : MonoBehaviour {
    ...
    }


这样会导出Custom类.

如果类型有基类,并且需要在lua中访问基类成员, 也需要导出基类, 如果基类是系统自带类或者第三方库类(不方便修改添加CustomLuaClassAttribute标签), 则可以使用第一种方法, 手动添加到导出列表.

在自定义的类中, 所有public 成员方法/静态方法/属性/数据成员都会导出.

如果对应的类型中, 存在 public 的 代理的属性/数据成员, 会自动加入导出, 否则需要手动加入上面List, 否则可能在运行是找不到对应的接口报错, 例如:

>      public SomeDelegate someDelegate;

会自动产生对应的导出代码, 但如果该代理为函数参数被使用, 则不会自动导出, 需要手动添加.


####自定义方法

任何具有[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]属性的static public方法, 都会尝试导出为自定义方法, 而不产生对应的包装方法, 例如 如下函数:

>     [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static public int instanceCustom(IntPtr l) {
        Custom self = (Custom)LuaObject.checkSelf(l);
        LuaDLL.lua_pushstring(l,"xiaoming");
        LuaDLL.lua_pushstring(l,"hanmeimei");
        LuaDLL.lua_pushinteger(l,self.v);
        return 3;
    }

仅仅自动注册到对应的lua接口里,不产生对应的包装方法再包装这个函数, 这使得你可以实现自己的任何lua函数, 用于自定义导出, 比如返回多个返回值.

在默认情况下, 上面的函数产生的是成员方法, 即它需要接受一个self的ud, 在lua层面需要 self:instanceCustom 的方式调用, 如果你需要个静态方法, 需要多加一个[StaticExport], 例如:

>     [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
>     [StaticExport]
    static public int staticCustom(IntPtr l) {
        LuaDLL.lua_pushstring(l,vs);
        LuaObject.pushObject(l, c);
        return 2;
    }

####指定不导出

对于某些public的成员, 可能并不需要导出, 导出对于lua也没有意义, 这个时候你可以添加[DoNotToLua]属性, 指定此成员不需要导出到lua,  例如:

>     [DoNotToLua]
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

以上方法, 数据, 属性都不会导出. 如果仅用于内部成员访问, 可以考虑使用internal可见性, 这样既能保证自己的代码可以访问到成员, 又不必添加[DoNotToLua]属性, 还能控制其不导出, 所以更推荐的做法是使用internal关键字.

####同名重载方法

slua支持同名重载方法, 但对于自己实现的接口(非来自UnityEngine), 不建议采用同名重载方法, 因为这样会降低slua的运行效率, 因为它比不同名的方法多一步参数匹配的过程, 同时重载方法的参数匹配不能严格区别参数的类型(主要是因为lua的类型少于c#),所以导致部分同名的重载工作不正常.

####可变参数方法调用

在c#里有params类型的可变参数调用, slua同样支持, 例如:

>     static public void func6(string str, params object[] args)
    {
        Debug.Log(str);
        for (int n = 0; n < args.Length; n++)
        {
            Debug.Log(args[n]);
        }
    }

需要注意的是, 可变参数函数不支持任何同名重载, 并且params修饰符必须针对最后一个参数.


#####Type参数

在slua里,基于效率和易用性的原则, 不建议导出System空间下的类型, 而使用变通方法来表达类似需求, 对于Type参数的传入, 对于导出类型,比如UnityEngine.GameObject, HelloWorld等,可以直接使用对应的lua table来当作参数传入, 在c#会理解为Type, 例如:

>     HelloWorld.ofunc(GameObject)

在c#端,有对应函数:

>     static public void ofunc(Type t) {
        Debug.Log(t.Name);
    }

对于没有导出的Type,原则上可以使用字符串来描述, 例如:

>     HelloWorld.ofunc("UnityEngine.GameObject,UnityEngine")

但目前采用同Type做为参数的方法如果存在重载方法, 则可能工作不正常, 建议避免使用同名重载.


####代理(delegate)

slua支持直接使用代理, 仅需要传入lua function, 这大大方便开发工作, 例如, 存在如下代理:

>     public delegate bool GetBundleInfoDelegate(string path, out string url);
    public GetBundleInfoDelegate d;

在lua端, 代码如下:

>     xxx.d=function(path)
        return true,url
    end

这样就完成了代理对象的设置, 同时注意out修饰符的url参数, 因为lua没有对应的机制, 如果需要返回url参数需要lua按顺序返回多个参数.

slua的delegate支持+=/-=操作, 例如
>     self={}
    function self.xxx()
		return function(a,b,c)
			self //here
		end
    end
    h.d={"+=",self.xxx()}
	h.d={"-=",self.xxx()}


上面的例子演示了, 如何在回调函数内使用self, 同时演示了如果+=/-= 代理函数

同时System.Action<>/System.Func<> 这种泛型代理也支持, slua会自动将遇到的泛型参数展开, 例如:

>public static Action<int, Dictionary<int, object>> daction;


##Coroutine(Yield)

Slua支持unity yield指令,  需要配和lua coroutine, 例如:

>     local c=coroutine.create(function()
		print "coroutine start"
		Yield(WaitForSeconds(2))
		print "coroutine WaitForSeconds 2"
		local www = WWW("http://www.sineysoft.com")
		Yield(www)
		print(www.bytes)
		print(#www.bytes)
	end)
	coroutine.resume(c)

在lua coroutine内使用Yield函数,可以中断当前运行的coroutine,直到yield的对象完成操作才会继续回来执行下面的代码. 注意, Yield函数不能在主线程调用.

##LuaVarObject

当返回一个没有导出的类型时, slua将自动返回一个表示LuaVarObject的userdata, 通过LuaVarObject, 你任然可以访问没有导出的类的方法和成员, 但LuaVarObject使用的反射的方法来访问, 这在slua中是非常不推荐的, 这将显著降低slua运行的效率, 对于频繁使用的类型请导出它们再使用,但对于某些场合,使用LuaVarObject还是很方便的, 这包括:

1) 你希望将一个没有导出的类, 仅作为函数参数传递, 而不在lua中调用其方法/成员;

2) 你非频繁的使用某些泛型类, 例如:

>     public Dictionary<string, GameObject> foo()
    {
        return new Dictionary<string, GameObject>();
    }

其中Dicionary<string,GameObject>并没有导出,但你可以在lua中调用其方法, 例如:

>     local dict = obj:foo()
	for i=1,10 do
		dict:Add(tostring(i),GameObject("dict"..i)) -- add k,v to Dictionary<string,GameObject>
	end
	dict["hello"] = GameObject("world")
	print("Dict count",dict.Count)

但请记住,上面的访问过程都是经过反射操作来完成的,速度不理想,应该避免在频繁运行的代码中使用给他们.

最后, ***LuaVarObject并没有完善, 仅满足最低使用需求, 如果你发现有任何bug, 需要自行完善他们, 作者欢迎你完善后提交pull request合并到slua主分支, 让你的代码成为slua的一部分.***

##LuaTimer

LuaTimer用于在限定时间周期性的回调lua函数, 强烈建议不要使用系统自带timer, slua timer会在lua虚拟机被关闭后停止timer工作,而一般系统自带timer可能会在lua虚拟机被关闭后任然触发timer,导致调用lua函数失败,从而产生闪退等.

###Add(delay,func) -> id

增加一个一次性Timer, timer在delay时间后触发, 单位ms.

###Add(delay,cycle,func) -> id

增加一个Timer, delay表示延迟时间,单位ms, cycle表示周期时间,单位ms, func为回调的lua函数, Add函数返回一个timer id,用于Delete函数删除某个已经添加的Timer, 例如:

>     LuaTimer.Add(0,20,function(id)
		cube.transform.localScale = Vector3(10,10,10)*(0.1+math.sin(os.clock()))
		cube2.transform.position = Vector3(math.sin(os.clock())*5,0,0)
		return true
	end)


添加一个立刻开始,20ms回调一次的Timer,回调函数的id参数表示该timer的id, 如果需要持续回调返回true,返回false或者没有返回值, 表示该回调仅执行一次.

###Delete(id)

删除指定id的timer.


##如何快速导出第三方库, 例如ngui等

新建一个空工程,将第三方库的所有代码放入Assets内, 等待Unity编译完成;
打开产生的sln工程,找到 Assembly-CSharp 工程, 修改工程"程序集名称"由Assembly-CSharp改为第三方库名称,例如NGUI;
选择目标框架为".net Subset Base class Libraries";
调整为Release版本, 然后生成对应的dll;
将dll放入slua/3rdlib目录;
打开CustomExport.cs, 找到OnAddCustomAssembly() 函数

在List内添加程序集名字, 例如:

>     list.Add("NGUI");

保存, 等待编译完成, 点击Make custom,将会生成NGUI的全部接口文件.

**注意去掉对UnityEditor的引用，否则发布的时候可能失败, 因为手机环境下没有UnityEditor的运行环境**


##编译slua库

编译slua库非常简单, 仅需要把slua加入 lua/luajit 的make文件, 按照对应平台的make方法就可以产生对应平台的库文件, 以 luajit2.1 生成 64位 iOS 系统的库文件为例:

首先下载luajit2.1 代码:

>git clone http://repo.or.cz/luajit-2.0.git

切换到2.1分支

>git checkout v2.1

在luajit目录下,创建make_ios.sh脚本, 内容如下:

	#!/usr/bin/env bash
	DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"
	LIPO="xcrun -sdk iphoneos lipo"
	STRIP="xcrun -sdk iphoneos strip"
	
	IXCODE=`xcode-select -print-path`
	ISDK=$IXCODE/Platforms/iPhoneOS.platform/Developer
	ISDKVER=iPhoneOS8.1.sdk
	ISDKP=$IXCODE/usr/bin/
	
	if [ ! -e $ISDKP/ar ]; then 
	  sudo cp $ISDK/usr/bin/ar $ISDKP
	fi
	
	if [ ! -e $ISDKP/ranlib ]; then
	  sudo cp $ISDK/usr/bin/ranlib $ISDKP
	fi
	
	if [ ! -e $ISDKP/strip ]; then
	  sudo cp $ISDK/usr/bin/strip $ISDKP
	fi
	
	make clean
	ISDKF="-arch arm64 -isysroot $ISDK/SDKs/$ISDKVER"
	make HOST_CC="gcc " CROSS="$ISDKP" TARGET_FLAGS="$ISDKF" TARGET=arm64 TARGET_SYS=iOS

注意上面编译脚本采用iOS8.1 sdk

将slua.c 复制进入luajit/src目录, 并修改src目录下 Makefile 文件, 在LJCORE_O = 段最后 加入 slua.o, 保存退出.

然后在luajit目录运行

>chmod +x make_ios.sh

>./make_ios.sh

这样便在src目录生成了libluajit.a库文件, 修改文件为libslua.a, 放入Assets/Plugins/iOS 目录即可.

##常见问题

1) “我用luajit编译的dll可以使用，但是我用lua5.3编译的dll会导致unity闪退，怎么办”

增加lua_5_3的宏，删除Library目录，重新打开unity，就可以了，是因为之前的缓存代码是针对luajit的

2) "Some function push more value to lua stack" / "Some function not remove temp value from lua stack. You should fix it."输出表示什么含义？

如果你修改了代码，说明你修改的代码push了数据到lua堆栈上，但没有把他们pop出来，导致堆栈上残留了这些数据，slua则给出一个warning，需要你找到对应的代码，修复它。如果你确定没有修改代码，请报告，这可能是一个bug。

3)为什么我看不到slua菜单?

如果存在任何编译器错误, 都可能导致slua菜单丢失, 这是unity editor自身的限制, 所以你需要解决编译错误.

4)为什么我把slua放在assets目录后一堆编译错误?

默认slua是针对unity4.6.1生成的wrap文件, 如果你使用其他版本, 可以有部分接口定义不同导致无法编译, 你可以删除luaobject目录后, ***等待编译完成,出现slua菜单***,重新make, make ui, make custom.

5)为什么lua文件用txt后缀而不是lua?

考虑到发布到UnityStore的需要,以及Resource目录的加载策略,使用txt是最方便的, 如果你自己重写loader,可以使用lua后缀.

6)Lua文件是否可以使用二进制字节码形式?

可以, 针对使用的lua版本(lua/5.1/jit), 需要找到对应的luac程序生成字节码.

7)如何 require 动态更新的lua文件?

如果你的lua文件是通过动态下载asset bundle获得或者直接http下载获得(即lua代码热更新),需要自己实现loader, 你可以添加LuaState.loaderDelegate代理完成自己的加载请求, 具体可以参考LusState.cs代码.


##已知问题
不支持泛型函数导出, 但支持泛型代理

UnityAction/UnityEvent目前仅支持1个泛型参数的版本,后续考虑完善.

部分同名重载参数类型检查可能会失败(因为lua的类型少于c#), 建议手写代码避免同名重载, 这样效率也更高.

返回没有导出的类型, 会采用LuaVarObject, 这个类退化为使用反射, 并且并没有完善, 不建议返回没有导出的类, 简单例子可以参考varobj工程.
