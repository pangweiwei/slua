#Slua 帮助

slua是Unity3D导出为lua的自动化代码生成工具, 通过产生静态的导出代码, 可以不依赖反射的情况大幅度提高运行效率, 优化程度基本与手写导出代码一致, 同时通过小心优化, slua避免了大多数不必要的gc alloc, slua是目前最有效率的Unity3D lua导出解决方案.

##安装

通过git clone复制一份代码到你的资源目录(Assets目录内), slua的发布版已经附带了Unity3D 4.6.1 的导出接口文件, 在Slua/LuaObject内, 你可以删除该目录内(不包含Custom子目录)所有文件, 等待脚本编译完成, 点击slua菜单中 Make 命令 手动生成针对当前版本的U3d接口文件.



##导出接口

###自动导出

slua会自动导出UnityEngine的大部分接口, 导出UnityEngine.UI( 需要Unity3d 4.6+ )的全部接口, 这只需要通过点击Slua 菜单Make 和 Make UI命令,就会自动产生对应的接口文件, 你可能会发现一些UnityEngine的接口并没有导出, 被忽略的接口主要是平台相关,或者极少没用到的接口, 如果这些接口你也需要导出, 请手动修改代码 LuaCodeGen.cs 文件 的noUseList列表, 这个列表写明了那些接口不需要导出. 同时有部分接口可能在移动平台上不存在, 这导致在发布移动平台的时候报告找不到接口的错误, 所以默认slua已经将4.6.1中遇到的这部分接口也屏蔽了, 在未来的版本中可能遇到更多类似接口, 你仅需要将对应的接口加入 memberFilter 列表即可, 例如: 
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

slua支持手动导出任何自定义接口, 为此你仅需要将对应的类加入LuaCodeGen Custom() 函数的 cust列表里, 例如:
>     List<Type> cust = new List<Type>{
 			typeof(HelloWorld),
            typeof(Custom),
            typeof(System.Func<int>),
            typeof(System.Action<int,string>),
            typeof(System.Action<int, Dictionary<int,object>>),
            typeof(Deleg),
            // your custom class here
		};

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

在默认情况下, 上面的函数产生的是成员方法, 即它需要接受一个self的ud, 在lua层面需要 self:instanceCustom 的方式调用, 如果你需要个静态方法, 需要多一个false参数, 例如:

>     [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction),false)]
    static public int staticCustom(IntPtr l) {
        LuaDLL.lua_pushstring(l,vs);
        LuaObject.pushObject(l, c);
        return 2;
    }

####同名重载方法

slua支持同名重载方法, 但对于自己实现的接口(非来自UnityEngine), 不见采用同名重载方法, 因为这样会降低slua的运行效率, 因为它比不同的方法同一步参数匹配的过程, 同时重载方法的参数匹配不能严格区别参数的类型(主要是因为lua的类型少于c#),所以导致部分同名的重载工作不正常.

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

