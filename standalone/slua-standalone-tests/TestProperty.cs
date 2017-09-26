using System;
using NUnit.Framework;

namespace SLua.Test
{
    [TestFixture]
    public class TestProperty
    {
        private LuaSvr luaSvr;
            
        [SetUp]
        public void Init()
        {
            luaSvr = new LuaSvr();
            luaSvr.init(x => { }, () => { });
        }

        public ulong PublicProperty
        {
            get { return 321321321; }
        }

        private ulong PrivateProperty
        {
            get { return 123123123; }
        }
        public decimal PublicSetter { get; private set; }
        private decimal PrivateSetter { get; set; }

        [Test]
        public void TestGetter()
        {
            var code = @"
function Func(obj)
    return obj.PublicProperty, obj. PrivateProperty
end

return Func
";
            var ret = LuaSvr.mainState.doString(code);
            Assert.AreEqual(typeof (LuaFunction), ret.GetType());
            var func = ret as LuaFunction;
            var ret2 = func.call(this);
            Assert.AreEqual(typeof (object[]), ret2.GetType());
            var results = ret2 as object[];
            Assert.AreEqual(321321321, results[0]);
            Assert.AreEqual(123123123, results[1]);
        }
        [Test]
        public void TestSetter()
        {
            var code = @"
function Func(obj)
    obj.PublicSetter = 123123123
    obj.PrivateSetter = 321321321
end

return Func
";
            var ret = LuaSvr.mainState.doString(code);
            Assert.AreEqual(typeof (LuaFunction), ret.GetType());
            var func = ret as LuaFunction;
            var ret2 = func.call(this);
            Assert.AreEqual(null, ret2);
            Assert.AreEqual(123123123, this.PublicSetter);
            Assert.AreEqual(321321321, this.PrivateSetter);

        }
    }
}
