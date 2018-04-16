using System.Collections.Generic;
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
            private int ParentField = 0;

            public int GetParentField
            {
                get { return ParentField; }
            }

        }

        private class ChildClass : ParentClass
        {
            private uint ChildField = 0;

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
            var ret = LuaSvr.mainState.doString(code);
            Assert.AreEqual(ret.GetType(), typeof(ChildClass));
            var childObj = ret as ChildClass;
            Assert.AreEqual(childObj.GetParentField, 123);
            Assert.AreEqual(childObj.GetChildField, 321);



        }

        [Test]
        public void DictionaryStringKeyGet()
        {
            var dict = new Dictionary<string, ushort>();
            dict["TestString"] = 321;
            var code = @"
function Func(dict)
    dict['TestString'] = 888
    return dict['TestString']
end
return Func
";
            var ret = LuaSvr.mainState.doString(code);
            var func = ret as LuaFunction;
            var result = func.call(dict);

            Assert.AreEqual(888, result);
        }

        [Test]
        public void DictionaryUShortKeyGet()
        {
            var dict = new Dictionary<ushort, ushort>();
            dict[123] = 321;
            var code = @"
function Func(dict)
    dict[123] = 888
    return dict[123]
end
return Func
";
            var ret = LuaSvr.mainState.doString(code);
            var func = ret as LuaFunction;
            var result = func.call(dict);

            Assert.AreEqual(888, result);
        }

        [Test]
        public void DictionaryObjectKeyGet()
        {
            var dict = new Dictionary<object, ushort>();
            dict[123] = 321;
            var code = @"
function Func(dict)
    dict[123] = 888
    return dict[123]
end
return Func
";
            var ret = LuaSvr.mainState.doString(code);
            var func = ret as LuaFunction;
            var result = func.call(dict);

            Assert.AreEqual(888, result);
        }

        [Test]
        public void DictionaryClassKey()
        {
            var child = new ChildClass();
            var dict = new Dictionary<object, ulong>();
            dict[child] = 321;
            var code = @"
function Func(dict, child)
    dict[child] = 888
    return dict[child]
end
return Func
";
            var ret = LuaSvr.mainState.doString(code);
            var func = ret as LuaFunction;
            var result = func.call(dict, child);

            Assert.AreEqual(888, result);
        }
    }
}