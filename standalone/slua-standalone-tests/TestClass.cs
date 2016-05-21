using NUnit.Framework;

namespace SLua.Test
{
    [TestFixture]
    public class TestClass
    {
        private LuaSvr luaSvr;

        [SetUp]
        public void Init()
        {
            luaSvr = new LuaSvr();
            luaSvr.init(x => { }, () => { });
        }

        private class ParentClass
        {
            private int ParentField;

            public int GetParentField
            {
                get { return ParentField; }
            }

        }

        private class ChildClass : ParentClass
        {
            private uint ChildField;

            public uint GetChildField
            {
                get { return ChildField; }
            }
        }

        [Test]
        public void SetParentClassField()
        {
            var code = @"
local childClass = Slua.CreateClass('SLua.Test.TestClass+ChildClass') 
childClass.ParentField = 123
childClass.ChildField = 321
return childClass
";
            var ret = luaSvr.luaState.doString(code);
            Assert.AreEqual(ret.GetType(), typeof(ChildClass));
            var childObj = ret as ChildClass;
            Assert.AreEqual(childObj.GetParentField, 123);
            Assert.AreEqual(childObj.GetChildField, 321);



        }

    }
}