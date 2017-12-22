using NUnit.Framework;

namespace SLua.Test
{
    [TestFixture]
    public class TestStruct
    {
        private LuaSvr luaSvr;
            
        [SetUp]
        public void Init()
        {
            luaSvr = new LuaSvr();
            luaSvr.init(x => { }, () => { });
        }

        public struct Vector3
        {
            public float X;
            public float Y;
            public float Z;

            public Vector3(float x, float y, float z)
            {
                X = x;
                Y = y;
                Z = z;
            }
            public Vector3(float x, float y)
            {
                X = x;
                Y = y;
                Z = 0;
            }
        }

        public struct Vector2
        {
            public float X;
            public float Y;

            public Vector2(float x, float y)
            {
                X = x;
                Y = y;
            }
        }

        static void DoMethod(Vector3 v1, Vector2 v2)
        {
            Assert.AreEqual(v1.X, v2.X);
            Assert.AreEqual(v1.Y, v2.Y);
        }

        [Test]
        public void DoMethodWithStructArg()
        {
            var code = @"
local v1 = Slua.CreateClass('SLua.Test.TestStruct+Vector3', 1.52, 2.5, 3.5);
local v2 = Slua.CreateClass('SLua.Test.TestStruct+Vector2', 1.52, 2.5);
local TestStruct = Slua.GetClass('SLua.Test.TestStruct')
TestStruct.DoMethod(v1, v2)
return 1
";
            var ret = LuaSvr.mainState.doString(code);
            Assert.AreEqual(1, ret);
        }

        [Test]
        public void CreateStructVector3()
        {
            var code = @"
    local v = Slua.CreateClass('SLua.Test.TestStruct+Vector3', 1.5, 2.5)
    return v
";
            var ret = LuaSvr.mainState.doString(code);
            Assert.AreEqual(ret, new Vector3(1.5f, 2.5f, 0.0f));

            code = @"
    local v = Slua.CreateClass('SLua.Test.TestStruct+Vector3', 1.5, 2.5, 3.5)
    return v
";
            ret = LuaSvr.mainState.doString(code);
            Assert.AreEqual(ret.GetType(), typeof(Vector3));
            Assert.AreEqual(((Vector3)ret).Z, 3.5f);
        }

        /// <summary>
        /// Test Create a struct , like Vector2
        /// </summary>
        [Test]
        public void CreateStructVector2()
        {
            var luaSvr = new LuaSvr();
            luaSvr.init(x => { }, () => { });

            var code = @"
    local v = Slua.CreateClass('SLua.Test.TestStruct+Vector2', 1, 2)
    return v
";
            var ret = LuaSvr.mainState.doString(code);
            Assert.AreEqual(ret, new Vector2(1, 2f));
        }
    }
}