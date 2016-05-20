using NUnit.Framework;

namespace SLua.Test
{
    [TestFixture]
    public class TestEnum
    {
        public enum EnumType
        {
            AlphaEnum,
            BetaEnum,
            CatEnum,
            DogEnum,
            FlyEnum
        }

        public EnumType EnumValue = EnumType.AlphaEnum;

        private LuaSvr luaSvr;

        [SetUp]
        public void Init()
        {
            luaSvr = new LuaSvr();
            luaSvr.init(x => { }, () => { });
        }

        [Test]
        public void TestSetEnum()
        {
            var code = @"
function Func(this, arg2)
    this.EnumValue = arg2
end

return Func
";
            var ret = luaSvr.luaState.doString(code);
            Assert.AreEqual(typeof(LuaFunction), ret.GetType());

            this.EnumValue = EnumType.AlphaEnum;
            var func = ret as LuaFunction;
            func.call(this, EnumType.FlyEnum);
            Assert.AreEqual(EnumType.FlyEnum, this.EnumValue);
        }

        [Test]
        public void TestSetEnum2()
        {
            var code = @"
function Func(this)
    this.EnumValue = 3 -- DogEnum
end

return Func
";
            var ret = luaSvr.luaState.doString(code);
            Assert.AreEqual(typeof(LuaFunction), ret.GetType());


            this.EnumValue = EnumType.AlphaEnum;
            var func = ret as LuaFunction;
            func.call(this, 123123);  // arg 2, useless
            Assert.AreEqual(EnumType.DogEnum, this.EnumValue);
        }

        [Test]
        public void TestSetEnum3()
        {
            var code = @"
local EnumType = Slua.GetClass('SLua.Test.TestEnum+EnumType')

function Func(this)
    this.EnumValue = EnumType.BetaEnum
end

return Func
";
            var ret = luaSvr.luaState.doString(code);
            Assert.AreEqual(typeof(LuaFunction), ret.GetType());

            this.EnumValue = EnumType.AlphaEnum;
            var func = ret as LuaFunction;
            func.call(this);  // arg 2, useless
            Assert.AreEqual(EnumType.BetaEnum, this.EnumValue);
        }

    }
}