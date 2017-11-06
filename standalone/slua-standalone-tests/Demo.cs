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
