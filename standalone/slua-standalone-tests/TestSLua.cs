using System.Reflection;
using System.Text;
using NUnit.Framework;

namespace SLua.Test
{
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
            luaSvr.init((x) => { }, () => { });
            var code = @"
local testVar = 12345;
return testVar;
";
            object ret;
            luaSvr.luaState.doBuffer(Encoding.UTF8.GetBytes(code), "TestLua", out ret);
            Assert.AreEqual(ret, 12345);
        }

        [Test]
        public void TestSLuaLib()
        {
            var luaSvr = new LuaSvr();
            luaSvr.init(x => { }, () => { });
            var code = @"
local TestSLua = Slua.GetClass('SLua.Test.TestSLua')
return TestSLua
";
            var ret = luaSvr.luaState.doString(code);
            Assert.AreEqual("SLua.LuaClassObject", ret.GetType().ToString());

            var clsField = ret.GetType().GetField("cls", BindingFlags.NonPublic | BindingFlags.Instance);
            var cls = clsField.GetValue(ret);
            Assert.AreEqual(typeof(TestSLua), cls);
        }
    }
}