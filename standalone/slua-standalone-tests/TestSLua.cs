using System.Text;
using NUnit.Framework;
using SLua;

[TestFixture]
public class TestSLua
{
    [Test]
    public void TestLuaState()
    {
        var luaState = new LuaState();
        var obj = luaState.doString("print 'abc';return 123");
        Assert.AreEqual(obj, 123);
    }

    [Test]
    public void TestLuaSvr()
    {
        var luaSvr = new LuaSvr();
        luaSvr.init((x) => { }, () => { } );
        var code = @"
local testVar = 12345;
return testVar;
";
        object ret;
        luaSvr.luaState.doBuffer(Encoding.UTF8.GetBytes(code), "TestLua", out ret);
        Assert.AreEqual(ret, 12345);
    }
}