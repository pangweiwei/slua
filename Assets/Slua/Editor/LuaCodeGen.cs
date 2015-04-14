// The MIT License (MIT)

// Copyright 2015 Siney/Pangweiwei siney@yeah.net
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using System.Reflection;
using UnityEditor;
using LuaInterface;
using System.Text;
using System.Text.RegularExpressions;

public class LuaCodeGen : MonoBehaviour
{


    public static string path = "Assets/Slua/LuaObject/";


    [InitializeOnLoad]
    public class Startup
    {

        static Startup()
        {
            bool ok = System.IO.Directory.Exists(path);
            if (!ok && EditorUtility.DisplayDialog("Slua", "Not found lua interface for Unity, generate it now?", "Generate", "No"))
            {
                GenerateAll();
            }
        }
    }
		
    [MenuItem("SLua/All/Make")]
    static public void GenerateAll()
    {
		Generate();
		GenerateUI();
		Custom();
        Generate3rdDll();
	}
		
    [MenuItem("SLua/Unity/Make UnityEngine")]
    static public void Generate()
    {
        Assembly assembly = Assembly.Load("UnityEngine");
        Type[] types = assembly.GetExportedTypes();

		List<string> uselist;
		List<string> noUseList;

		CustomExport.OnGetNoUseList(out noUseList);
		CustomExport.OnGetUseList(out uselist);

        List<Type> exports = new List<Type>();
        string oldpath = path;
        path += "Unity/";
        foreach(Type t in types)
        {
            bool export=true;

			// check type in uselist
			if (uselist != null && uselist.Count > 0)
			{
				export = false;
				foreach (string str in uselist)
				{
					if (t.FullName==str)
					{
						export = true;
						break;
					}
				}
			}
			else
			{
				// check type not in nouselist
				foreach (string str in noUseList)
				{
					if (t.FullName.Contains(str))
					{
						export = false;
						break;
					}
				}
			}

            if (export)
            {
                if(Generate(t))
                    exports.Add(t);
            }
        }

        GenerateBind(exports,"BindUnity",0);
        
        AssetDatabase.Refresh();
        path = oldpath;
		Debug.Log("Generate engine interface finished");
    }

    [MenuItem("SLua/Unity/Make UI (for Unity4.6+)")]
    static public void GenerateUI()
    {
        List<string> noUseList = new List<string>
        {      
            "CoroutineTween",
			"GraphicRebuildTracker",
		};

        Assembly assembly = Assembly.Load("UnityEngine.UI");
        Type[] types = assembly.GetExportedTypes();

        List<Type> exports = new List<Type>();
        string oldpath = path;
        path += "Unity/";
        foreach (Type t in types)
        {
            bool export = true;

            foreach (string str in noUseList)
            {
                if (t.FullName.Contains(str))
                    export = false;
            }

            if (export)
            {
                if(Generate(t))
                    exports.Add(t);
            }

        }

        GenerateBind(exports, "BindUnityUI",1);

        AssetDatabase.Refresh();
        path = oldpath;
		Debug.Log("Generate UI interface finished");
    }

    [MenuItem("SLua/Unity/Clear Uinty UI")]
    static public void ClearUnity()
    {
        clear(new string[] { path + "Unity" });
        Debug.Log("Clear Unity & UI complete.");
    }
    static public bool IsObsolete(MemberInfo t)
    {
        return t.GetCustomAttributes(typeof(ObsoleteAttribute), false).Length > 0;
    }

    [MenuItem("SLua/Custom/Make")]
    static public void Custom()
    {

        List<Type> cust = new List<Type>();
        CustomExport.OnAddCustomClass(ref cust);

        // export self-dll
        Assembly assembly = Assembly.Load("Assembly-CSharp");
        Type[] types = assembly.GetExportedTypes();

        foreach (Type t in types)
        {
            if (t.GetCustomAttributes(typeof(CustomLuaClassAttribute), false).Length > 0)
            {
                cust.Add(t);
            }
        }

        // export 3rd dll
        //List<string> assemblyList = new List<string>();
        //CustomExport.OnAddCustomAssembly(ref assemblyList);
        
        //foreach (string assemblyItem in assemblyList)
        //{
        //    assembly = Assembly.Load(assemblyItem);
        //    types = assembly.GetExportedTypes();

        //    foreach (Type t in types)
        //    {
        //        cust.Add(t);
        //    }
        //}

        List<Type> exports = new List<Type>();
        string oldpath = path;
        path += "Custom/";

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        foreach (Type t in cust)
        {
            if (Generate(t))
                exports.Add(t);
        }

        GenerateBind(exports,"BindCustom",3);
        AssetDatabase.Refresh();
        path = oldpath;

		Debug.Log("Generate custom interface finished");
    }

    [MenuItem("SLua/3rdDll/Make")]
    static public void Generate3rdDll()
    {
        List<Type> cust = new List<Type>();
        Assembly assembly = Assembly.Load("Assembly-CSharp");
        Type[] types = assembly.GetExportedTypes();
        List<string> assemblyList = new List<string>();
        CustomExport.OnAddCustomAssembly(ref assemblyList);
        foreach (string assemblyItem in assemblyList)
        {
            assembly = Assembly.Load(assemblyItem);
            types = assembly.GetExportedTypes();
            foreach (Type t in types)
            {
                cust.Add(t);
            }
        }
        if (cust.Count > 0)
        {
            List<Type> exports = new List<Type>();
            string oldpath = path;
            path += "Dll/";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            foreach (Type t in cust)
            {
                if (Generate(t))
                    exports.Add(t);
            }
            GenerateBind(exports, "BindDll",2);
            AssetDatabase.Refresh();
            path = oldpath;
            Debug.Log("Generate 3rdDll interface finished");
        }
    }
    [MenuItem("SLua/3rdDll/Clear")]
    static public void Clear3rdDll()
    {
        clear(new string[] { path + "Dll" });
        Debug.Log("Clear AssemblyDll complete.");
    }
    [MenuItem("SLua/Custom/Clear")]
    static public void ClearCustom()
    {
        clear(new string[]{path+"Custom"});
        Debug.Log("Clear custom complete.");
    }

    [MenuItem("SLua/All/Clear")]
    static public void ClearALL()
    {
        clear(new string[] { path.Substring(0, path.Length - 1) });
        Debug.Log("Clear all complete.");
    }

    static void clear(string[] paths)
    {
        try
        {
            foreach (string path in paths)
            {
                System.IO.Directory.Delete(path, true);
            }
        } catch {

        }
        
        AssetDatabase.Refresh();
    }

    static bool Generate(Type t)
    {
        if (t.IsInterface)
            return false;

        CodeGenerator cg = new CodeGenerator();
        return cg.Generate(t);
    }

    static void GenerateBind(List<Type> list,string name,int order)
    {
        CodeGenerator cg = new CodeGenerator();
        cg.GenerateBind(list,name,order);
    }

}

class CodeGenerator
{
    static List<string> memberFilter = new List<string>
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
        // i don't why below 2 functions missed in iOS platform
        "Graphic.OnRebuildRequested",
        "Text.OnRebuildRequested",
        // il2cpp not exixts
        "Application.ExternalEval",
        "GameObject.networkView",
        "Component.networkView",
        // unity5
        "AnimatorControllerParameter.name",
        "Input.IsJoystickPreconfigured",
        "Resources.LoadAssetAtPath",
    };

    HashSet<string> funcname = new HashSet<string>();
    Dictionary<string, bool> directfunc = new Dictionary<string, bool>();
    class PropPair
    {
        public string get="null";
        public string set="null";
        public bool isInstance = true;
    }
    Dictionary<string, PropPair> propname = new Dictionary<string, PropPair>();

    int indent = 0;

    public void GenerateBind(List<Type> list,string name,int order)
    {
        HashSet<Type> exported = new HashSet<Type>();
        string f = LuaCodeGen.path + name+".cs";
        StreamWriter file = new StreamWriter(f,false,Encoding.UTF8);
        Write(file, "using System;");
        Write(file, "namespace SLua {");
		Write(file, "[LuaBinder({0})]",order);
        Write(file, "public class {0} {{",name);
        Write(file, "public static void Bind(IntPtr l) {");
        foreach (Type t in list)
        {
            WriteBindType(file, t, list, exported);
        }
        Write(file, "}");
        Write(file, "}");
        Write(file, "}");
        file.Close();
    }

    void WriteBindType(StreamWriter file, Type t, List<Type> exported, HashSet<Type> binded)
    {
        if (t == null || binded.Contains(t) || !exported.Contains(t))
            return;

        WriteBindType(file, t.BaseType, exported, binded);
        Write(file, "{0}.reg(l);", ExportName(t), binded);
        binded.Add(t);
    }


    public bool Generate(Type t)
    {
        if( !Directory.Exists(LuaCodeGen.path) )
        {
            Directory.CreateDirectory(LuaCodeGen.path);
        }
        
		if ((!t.IsGenericType && !IsObsolete(t) && t!=typeof(YieldInstruction) && t!=typeof(Coroutine))
            || (t.BaseType!=null && t.BaseType==typeof(System.MulticastDelegate)))
        {
            if (t.IsEnum)
            {
                StreamWriter file = Begin(t);
                WriteHead(t, file);
                RegEnumFunction(t, file);
                End(file);
            }
            else if (t.BaseType == typeof(System.MulticastDelegate))
            {
                string f;
                if (t.IsGenericType)
                {
                    if (t.ContainsGenericParameters)
                        return false;

                    string fn = string.Format("Lua{0}_{1}.cs", _Name(GenericBaseName(t)), _Name(GenericName(t)));
                    f = LuaCodeGen.path + fn;
                }
                else
                {
                    f = LuaCodeGen.path + "LuaDelegate_" + _Name(t.FullName) + ".cs";
                }
                StreamWriter file = new StreamWriter(f, false, Encoding.UTF8);
                WriteDelegate(t, file);
                file.Close();
                return false;
            }
            else
            {
                funcname.Clear();
                propname.Clear();
                directfunc.Clear();

                StreamWriter file = Begin(t);
                WriteHead(t, file);
                WriteConstructor(t, file);
                WriteFunction(t, file);
                WriteFunction(t, file, true);
                WriteField(t, file);
                RegFunction(t, file);
                End(file);

                if (t.BaseType != null && t.BaseType.Name == "UnityEvent`1")
                {
                    string f = LuaCodeGen.path + "LuaUnityEvent_" + _Name(GenericName(t.BaseType)) + ".cs";
                    file = new StreamWriter(f, false, Encoding.UTF8);
                    WriteEvent(t, file);
                    file.Close();
                }
            }

            return true;
        }
        return false;
    }

    void WriteDelegate(Type t, StreamWriter file)
    {
        string temp = @"
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    public partial class LuaDelegation : LuaObject
    {

        static internal int checkDelegate(IntPtr l,int p,out $FN ua) {
            int op = extractFunction(l,p);
			if(LuaDLL.lua_isnil(l,p)) {
				ua=null;
				return op;
			}
            else if (LuaDLL.lua_isuserdata(l, p)==1)
            {
                ua = ($FN)checkObj(l, p);
                return op;
            }
            LuaDelegate ld;
            checkType(l, -1, out ld);
            if(ld.d!=null)
            {
                ua = ($FN)ld.d;
                return op;
            }
			LuaDLL.lua_pop(l,1);
            ua = ($ARGS) =>
            {
                int error = pushTry(l);
";
        
        temp = temp.Replace("$TN", t.Name);
        temp = temp.Replace("$FN", SimpleType(t));
        MethodInfo mi = t.GetMethod("Invoke");
        List<int> outindex = new List<int>();
        List<int> refindex = new List<int>();
        temp = temp.Replace("$ARGS", ArgsList(mi, ref outindex, ref refindex));
        Write(file, temp);

        this.indent = 4;

        for (int n = 0; n < mi.GetParameters().Length; n++)
        {
            if(!outindex.Contains(n))
                Write(file, "pushValue(l,a{0});",n+1);
        }

        Write(file, "ld.call({0}, error);", mi.GetParameters().Length - outindex.Count);

        if (mi.ReturnType != typeof(void))
            WriteValueCheck(file, mi.ReturnType, 1, "ret", "error+");

        foreach(int i in outindex) {
            string a=string.Format("a{0}",i+1);
            WriteCheckType(file, mi.GetParameters()[i].ParameterType, i+1, a, "error+");
        }

        foreach (int i in refindex)
        {
            string a = string.Format("a{0}", i + 1);
            WriteCheckType(file, mi.GetParameters()[i].ParameterType, i+1, a, "error+");
        }


        Write(file, "LuaDLL.lua_settop(l, error-1);");
        if (mi.ReturnType != typeof(void))
            Write(file, "return ret;");

        Write(file,"};");
		Write(file,"ld.d=ua;");
        Write(file,"return op;");
        Write(file,"}");
        Write(file,"}");
        Write(file, "}");
    }

    string ArgsList(MethodInfo m, ref List<int> outindex, ref List<int> refindex)
    {
		string str = "";
        ParameterInfo[] pars = m.GetParameters();
        for (int n = 0; n < pars.Length; n++)
        {
            string t=SimpleType(pars[n].ParameterType);


            ParameterInfo p = pars[n];
            if (p.ParameterType.IsByRef && p.IsOut)
            {
                str += string.Format("out {0} a{1}", t, n + 1);
                outindex.Add(n);
            }
            else if (p.ParameterType.IsByRef)
            {
                str += string.Format("ref {0} a{1}", t, n + 1);
                refindex.Add(n);
            }
            else
                str += string.Format("{0} a{1}", t, n + 1);
            if (n < pars.Length - 1)
                str += ",";


        }
        return str;
    }

    void tryMake(Type t)
    {
        
        if (t.BaseType == typeof(System.MulticastDelegate))
        {
            CodeGenerator cg = new CodeGenerator();
            cg.Generate(t);
        }
    }

    void WriteEvent(Type t, StreamWriter file)
    {
        string temp = @"
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLua
{
    public class LuaUnityEvent_$CLS : LuaObject
    {

        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int AddListener(IntPtr l)
        {
            try
            {
                UnityEngine.Events.UnityEvent<$GN> self = checkSelf<UnityEngine.Events.UnityEvent<$GN>>(l);
                UnityEngine.Events.UnityAction<$GN> a1;
                checkType(l, 2, out a1);
                self.AddListener(a1);
                return 0;
            }
            catch (Exception e)
            {
                LuaDLL.luaL_error(l, e.ToString());
                return 0;
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int RemoveListener(IntPtr l)
        {
            try
            {
                UnityEngine.Events.UnityEvent<$GN> self = checkSelf<UnityEngine.Events.UnityEvent<$GN>>(l);
                UnityEngine.Events.UnityAction<$GN> a1;
                checkType(l, 2, out a1);
                self.RemoveListener(a1);
                return 0;
            }
            catch (Exception e)
            {
                LuaDLL.luaL_error(l, e.ToString());
                return 0;
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int Invoke(IntPtr l)
        {
            try
            {
                UnityEngine.Events.UnityEvent<$GN> self = checkSelf<UnityEngine.Events.UnityEvent<$GN>>(l);
                $GN o;
                checkType(l,2,out o);
                self.Invoke(o);
                return 0;
            }
            catch (Exception e)
            {
                LuaDLL.luaL_error(l, e.ToString());
                return 0;
            }
        }
        static public void reg(IntPtr l)
        {
            getTypeTable(l, typeof(LuaUnityEvent_$CLS).FullName);
            addMember(l, AddListener);
            addMember(l, RemoveListener);
            addMember(l, Invoke);
            createTypeMetatable(l, typeof(LuaUnityEvent_$CLS));
        }

        static bool checkType(IntPtr l,int p,out UnityEngine.Events.UnityAction<$GN> ua) {
            LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
            LuaDelegate ld;
            checkType(l, p, out ld);
            if (ld.d != null)
            {
                ua = (UnityEngine.Events.UnityAction<$GN>)ld.d;
                return true;
            }
            ua = ($GN v) =>
            {
                int error = pushTry(l);
                pushValue(l, v);
                ld.call(1, error);
                LuaDLL.lua_settop(l,error - 1);
            };
            ld.d = ua;
            return true;
        }
    }
}";


        temp = temp.Replace("$CLS", _Name(GenericName(t.BaseType)));
        temp = temp.Replace("$FNAME", FullName(t));
        temp = temp.Replace("$GN", GenericName(t.BaseType));
        Write(file, temp);
    }

    void RegEnumFunction(Type t, StreamWriter file)
    {
        // Write export function
        Write(file, "static public void reg(IntPtr l) {");
        Write(file, "getEnumTable(l,\"{0}\");", FullName(t));

        FieldInfo[] fields = t.GetFields();
        foreach (FieldInfo f in fields)
        {
            if (f.Name == "value__") continue;
            Write(file, "addMember(l,{0},\"{1}\");",(int)f.GetValue(null),f.Name);
        }

        Write(file, "LuaDLL.lua_pop(l, 1);");
        Write(file, "}");
    }


    StreamWriter Begin(Type t)
    {
        string clsname = ExportName(t);
        string f = LuaCodeGen.path + clsname + ".cs";
        StreamWriter file = new StreamWriter(f, false, Encoding.UTF8);
        return file;
    }
    private void End(StreamWriter file)
    {
        Write(file, "}");
        file.Flush();
        file.Close();
    }

    private void WriteHead(Type t,StreamWriter file)
    {
        Write(file, "using UnityEngine;");
        Write(file, "using System;");
        Write(file, "using LuaInterface;");
        Write(file, "using SLua;");
        Write(file, "using System.Collections.Generic;");
        Write(file, "public class {0} : LuaObject {{", ExportName(t));
        //Write(file, "static public List<LuaCSFunction> exportfuncs = new List<LuaCSFunction>();");
    }
    

    private void WriteFunction(Type t, StreamWriter file, bool writeStatic=false)
    {
        BindingFlags bf = BindingFlags.Public | BindingFlags.DeclaredOnly;
        if (writeStatic)
            bf |= BindingFlags.Static;
        else
            bf |= BindingFlags.Instance;

        MethodInfo[] members = t.GetMethods( bf );
        foreach (MethodInfo mi in members)
        {
            bool instanceFunc;
            if (writeStatic && isPInvoke(mi,out instanceFunc))
            {
                directfunc.Add(t.FullName + "." + mi.Name,instanceFunc);
                continue;
            }

            string fn = writeStatic ? staticName(mi.Name) : mi.Name;

            if (mi.MemberType == MemberTypes.Method
                && !IsObsolete(mi)
                && !DontExport(mi)
                && !funcname.Contains(fn)
                && isUsefullMethod(mi)
                && !MemberInFilter(t, mi))
            {
                WriteFunctionDec(file, fn);
                WriteFunctionImpl(file, mi, t, bf);
                funcname.Add(fn);
            }
        }
    }

    bool isPInvoke(MethodInfo mi,out bool instanceFunc)
    {
        object[] attrs = mi.GetCustomAttributes(typeof(MonoPInvokeCallbackAttribute), false);
        if (attrs.Length > 0)
        {
			instanceFunc = mi.GetCustomAttributes(typeof(StaticExportAttribute),false).Length==0;
            return true;
        }
        instanceFunc = true;
        return false;
    }

    string staticName(string name)
    {
        if (name.StartsWith("op_"))
            return name;
        return name + "_s";
    }


    bool MemberInFilter(Type t, MemberInfo mi)
    {
        return memberFilter.Contains(t.Name + "." + mi.Name);
    }

    bool IsObsolete(MemberInfo mi)
    {
        return LuaCodeGen.IsObsolete(mi);
    }

    void RegFunction(Type t, StreamWriter file)
    {
        // Write export function
        Write(file, "static public void reg(IntPtr l) {");

        if (t.BaseType != null && t.BaseType.Name.Contains("UnityEvent`"))
        {
            Write(file, "LuaUnityEvent_{1}.reg(l);", FullName(t), _Name((GenericName(t.BaseType)) ));
        }

        Write(file, "getTypeTable(l,\"{0}\");", FullName(t));
        foreach (string f in funcname)
        {
            Write(file, "addMember(l,{0});", f);
        }
        foreach (string f in directfunc.Keys)
        {
            bool instance = directfunc[f];
            Write(file, "addMember(l,{0},{1});", f, instance?"true":"false");
        }

        foreach (string f in propname.Keys)
        {
            PropPair pp = propname[f];
            Write(file, "addMember(l,\"{0}\",{1},{2},{3});", f,pp.get,pp.set,pp.isInstance?"true":"false");
        }
        if (t.BaseType != null && !CutBase(t.BaseType))
        {
            if (t.BaseType.Name.Contains("UnityEvent`1"))
				Write(file, "createTypeMetatable(l,{2}, typeof({0}),typeof(LuaUnityEvent_{1}));", FullName(t), _Name(GenericName(t.BaseType)),constructorOrNot(t));
            else
				Write(file, "createTypeMetatable(l,{2}, typeof({0}),typeof({1}));", FullName(t), TypeDecl(t.BaseType),constructorOrNot(t));
        }
        else
			Write(file, "createTypeMetatable(l,{1}, typeof({0}));", FullName(t),constructorOrNot(t));
        Write(file, "}");
    }

	string constructorOrNot(Type t) {
		ConstructorInfo[] cons = GetValidConstructor(t);
		if(cons.Length>0 || t.IsValueType)
			return "constructor";
		return "null";
	}

    bool CutBase(Type t)
    {
        if (t.FullName.StartsWith("System."))
            return true;
        return false;
    }

	void WriteSet(StreamWriter file,Type t,string cls,string fn,bool isstatic=false) 
	{
		if(t.BaseType==typeof(MulticastDelegate)) 
		{
			if(isstatic) {
				Write(file,"if(op==0) {0}.{1}=v;",cls,fn);
				Write(file,"else if(op==1) {0}.{1}+=v;",cls,fn);
				Write(file,"else if(op==2) {0}.{1}-=v;",cls,fn);
			} else {
				Write(file,"if(op==0) self.{0}=v;",fn);
				Write(file,"else if(op==1) self.{0}+=v;",fn);
				Write(file,"else if(op==2) self.{0}-=v;",fn);
			}
		}
		else 
		{
			if(isstatic) {
				Write(file, "{0}.{1}=v;", cls, fn);
			} else {
				Write(file, "self.{0}=v;", fn);
			}
		}
	}

    private void WriteField(Type t, StreamWriter file)
    {
        // Write field set/get

        FieldInfo[] fields = t.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance|BindingFlags.DeclaredOnly);
        foreach (FieldInfo fi in fields)
        {
            if (DontExport(fi) || IsObsolete(fi))
                continue;

			PropPair pp = new PropPair();
            pp.isInstance = !fi.IsStatic;

			if(fi.FieldType.BaseType!=typeof(MulticastDelegate))
			{
	            WriteFunctionAttr(file);
	            Write(file, "static public int get_{0}(IntPtr l) {{", fi.Name);
                WriteTry(file);
	            if (fi.IsStatic)
	            {
	                WritePushValue(fi.FieldType, file, string.Format("{0}.{1}", t.FullName, fi.Name));
	            }
	            else
	            {
                    WriteCheckSelf(file, t);
	                WritePushValue(fi.FieldType, file, string.Format("self.{0}", fi.Name));
	            }

	            Write(file, "return 1;");
                WriteCatchExecption(file);
	            Write(file, "}");
	            
	            pp.get = "get_" + fi.Name;
			}


            

            if (!fi.IsLiteral && !fi.IsInitOnly)
            {
                WriteFunctionAttr(file);
                Write(file, "static public int set_{0}(IntPtr l) {{", fi.Name);
                WriteTry(file);
                if (fi.IsStatic)
                {
                    Write(file, "{0} v;", TypeDecl(fi.FieldType));
                    WriteCheckType(file, fi.FieldType, 2);
					WriteSet(file,fi.FieldType,t.FullName,fi.Name,true);
                }
                else
                {
                    WriteCheckSelf(file, t);
                    Write(file, "{0} v;", TypeDecl(fi.FieldType));
                    WriteCheckType(file, fi.FieldType, 2);
					WriteSet(file,fi.FieldType,t.FullName,fi.Name);
                }

                if(t.IsValueType && !fi.IsStatic)
                    Write(file, "setBack(l,self);");
                Write(file, "return 0;");
                WriteCatchExecption(file);
                Write(file, "}");

                pp.set = "set_" + fi.Name;
            }

            propname.Add(fi.Name, pp);
            tryMake(fi.FieldType);
        }
		//for this[]
        List<PropertyInfo> getter = new List<PropertyInfo>();
        List<PropertyInfo> setter = new List<PropertyInfo>();
        // Write property set/get
        PropertyInfo[] props = t.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        foreach (PropertyInfo fi in props)
        {
            //if (fi.Name == "Item" || IsObsolete(fi) || MemberInFilter(t,fi) || DontExport(fi))
            if (IsObsolete(fi) || MemberInFilter(t, fi) || DontExport(fi))
                continue;
            if (fi.Name == "Item")
            {
				//for this[]
                if (!fi.GetGetMethod().IsStatic && fi.GetIndexParameters().Length == 1)
                {
                    if (fi.CanRead && !IsNotSupport(fi.PropertyType))
                        getter.Add(fi);
                    if (fi.CanWrite && fi.GetSetMethod() != null)
                        setter.Add(fi);
                }                
                continue;
            }
            PropPair pp = new PropPair();
            bool isInstance = true;

            if (fi.CanRead)
            {
                if (!IsNotSupport(fi.PropertyType))
                {
                    WriteFunctionAttr(file);
                    Write(file, "static public int get_{0}(IntPtr l) {{", fi.Name);
                    WriteTry(file);
                
                    if (fi.GetGetMethod().IsStatic)
                    {
                        isInstance = false;
                        WritePushValue(fi.PropertyType, file, string.Format("{0}.{1}", t.FullName, fi.Name));
                    }
                    else
                    {
                        WriteCheckSelf(file, t);
                        WritePushValue(fi.PropertyType, file, string.Format("self.{0}", fi.Name));
                    }

                    Write(file, "return 1;");
                    WriteCatchExecption(file);
                    Write(file, "}");
                    pp.get = "get_" + fi.Name;
                }
                
            }

            if (fi.CanWrite && fi.GetSetMethod()!=null)
            {
                WriteFunctionAttr(file);
                Write(file, "static public int set_{0}(IntPtr l) {{", fi.Name);
                WriteTry(file);
                if (fi.GetSetMethod().IsStatic)
                {
                    WriteValueCheck(file, fi.PropertyType, 2);
                    WriteSet(file, fi.PropertyType, t.FullName, fi.Name, true);
                    isInstance = false;
                }
                else
                {
                    WriteCheckSelf(file, t);
                    WriteValueCheck(file, fi.PropertyType, 2);
                    WriteSet(file, fi.PropertyType, t.FullName, fi.Name);
                }

                if (t.IsValueType)
                    Write(file, "setBack(l,self);");

                Write(file, "return 0;");
                WriteCatchExecption(file);
                Write(file, "}");
                pp.set = "set_" + fi.Name;
            }
            pp.isInstance = isInstance;

            propname.Add(fi.Name, pp);
            tryMake(fi.PropertyType);
        }
		//for this[]
        WriteThisFunc(t, file, getter, setter);
    }
    void WriteThisFunc(Type t, StreamWriter file, List<PropertyInfo> getter, List<PropertyInfo> setter)
    {

		//Write property this[] set/get
        if (getter.Count > 0)
        {
			//get
            bool first_get = true;
            WriteFunctionAttr(file);
            Write(file, "static public int getItem(IntPtr l) {");
            WriteTry(file);
            WriteCheckSelf(file, t);
            if (getter.Count == 1)
            {
                PropertyInfo _get = getter[0];
                ParameterInfo[] infos = _get.GetIndexParameters();
                WriteValueCheck(file, infos[0].ParameterType, 2, "v");
                Write(file, "var ret = self[v];");
                WritePushValue(_get.PropertyType, file, "ret");
                Write(file, "return 1;");
            }
            else
            {
                Write(file, "LuaTypes t = LuaDLL.lua_type(l, 2);");
                for (int i = 0; i < getter.Count; i++)
                {
                    PropertyInfo fii = getter[i];
                    ParameterInfo[] infos = fii.GetIndexParameters();
                    Write(file, "{0}(matchType(l,2,t,typeof({1}))){{", first_get ? "if" : "else if", infos[0].ParameterType);
                    WriteValueCheck(file, infos[0].ParameterType, 2, "v");
                    Write(file, "var ret = self[v];");
                    WritePushValue(fii.PropertyType, file, "ret");
                    Write(file, "return 1;");
                    Write(file, "}");
                    first_get = false;
                }
                Write(file, "LuaDLL.luaL_error(l,\"No matched override function to call\");");
                Write(file, "return 0;");
            }
            WriteCatchExecption(file);
            Write(file, "}");
            funcname.Add("getItem");
        }
        if (setter.Count > 0)
        {
            bool first_set = true;
            WriteFunctionAttr(file);
            Write(file, "static public int setItem(IntPtr l) {");
            WriteTry(file);
            WriteCheckSelf(file, t);
            if (setter.Count == 1)
            {
                PropertyInfo _set = setter[0];
                ParameterInfo[] infos = _set.GetIndexParameters();
                WriteValueCheck(file, infos[0].ParameterType, 2);
                WriteValueCheck(file, _set.PropertyType, 3, "c");
                Write(file, "self[v]=c;");
            }
            else
            {
                Write(file, "LuaTypes t = LuaDLL.lua_type(l, 2);");
                for (int i = 0; i < setter.Count; i++)
                {
                    PropertyInfo fii = setter[i];
                    if (t.BaseType != typeof(MulticastDelegate))
                    {
                        ParameterInfo[] infos = fii.GetIndexParameters();
                        Write(file, "{0}(matchType(l,2,t,typeof({1}))){{", first_set ? "if" : "else if", infos[0].ParameterType);
                        WriteValueCheck(file, infos[0].ParameterType, 2, "v");
                        WriteValueCheck(file, fii.PropertyType, 3, "c");
                        Write(file, "self[v]=c;");
                        Write(file, "return 0;");
                        Write(file, "}");
                        first_set = false;
                    }
                    if (t.IsValueType)
                        Write(file, "setBack(l,self);");
                }
                Write(file, "LuaDLL.luaL_error(l,\"No matched override function to call\");");
            }
            Write(file, "return 0;");
            WriteCatchExecption(file);
            Write(file, "}");
            funcname.Add("setItem");
        }
    }

    void WriteTry(StreamWriter file)
    {
        Write(file, "try {");
    }

    void WriteCatchExecption(StreamWriter file)
    {
        Write(file, "}");
        Write(file, "catch(Exception e) {");
        Write(file, "LuaDLL.luaL_error(l, e.ToString());");
        Write(file, "return 0;");
        Write(file, "}");
    }

    void WriteCheckType(StreamWriter file, Type t, int n, string v="v", string nprefix="")
    {
        if(t.IsEnum)
            Write(file, "checkEnum(l,{2}{0},out {1});", n,v,nprefix);
        else if(t.BaseType==typeof(System.MulticastDelegate))
			Write(file, "int op=LuaDelegation.checkDelegate(l,{2}{0},out {1});", n, v, nprefix);
        else
            Write(file, "checkType(l,{2}{0},out {1});", n, v,nprefix);
    }

    void WriteValueCheck(StreamWriter file, Type t, int n, string v = "v", string nprefix="")
    {
        Write(file, "{0} {1};", SimpleType(t),v);
        WriteCheckType(file,t, n,v,nprefix);
    }

    private void WriteFunctionAttr(StreamWriter file)
    {
        Write(file, "[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]");
    }

    ConstructorInfo[] GetValidConstructor(Type t)
    {
        List<ConstructorInfo> ret = new List<ConstructorInfo>();
        if (t.GetConstructor(Type.EmptyTypes) == null && t.IsAbstract && t.IsSealed)
            return ret.ToArray();
        if(t.BaseType!=null && t.BaseType.Name=="MonoBehaviour")
            return ret.ToArray();

        ConstructorInfo[] cons = t.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
        foreach (ConstructorInfo ci in cons)
        {
                if (!IsObsolete(ci) && !DontExport(ci))
                    ret.Add(ci);
        }
        return ret.ToArray();
    }

    bool DontExport(MemberInfo mi)
    {
        return mi.GetCustomAttributes(typeof(DoNotToLuaAttribute), false).Length > 0;
    }


    private void WriteConstructor(Type t, StreamWriter file)
    {
		ConstructorInfo[] cons = GetValidConstructor(t);
		if(cons.Length>0) {
	        WriteFunctionAttr(file);
	        Write(file, "static public int constructor(IntPtr l) {");
            WriteTry(file);
	        if (cons.Length > 0)
	        {
	            if (cons.Length > 1)
	                Write(file, "int argc = LuaDLL.lua_gettop(l);");
	            Write(file, "{0} o;", FullName(t));
	            bool first = true;
	            for (int n = 0; n < cons.Length; n++)
	            {
	                ConstructorInfo ci = cons[n];
	                ParameterInfo[] pars = ci.GetParameters();

	                if (cons.Length > 1)
	                {
	                    if (isUniqueArgsCount(cons, ci))
	                        Write(file, "{0}(argc=={1}){{", first ? "if" : "else if", ci.GetParameters().Length + 1);
	                    else
	                        Write(file, "{0}(matchType(l,argc,2{1})){{", first ? "if" : "else if", TypeDecl(pars));
	                }

	                for (int k = 0; k < pars.Length; k++)
	                {
	                    CheckArgument(file, pars[k].ParameterType, k, 2, false, false);
	                }
	                Write(file, "o=new {0}({1});", FullName(t), FuncCall(ci));
	                Write(file, "pushValue(l,o);");
	                Write(file, "return 1;");
                    if(cons.Length==1)
                        WriteCatchExecption(file);
	                Write(file, "}");
	                first = false;
	            }
	            
	        }

	        if (cons.Length>1)
	        {
	            Write(file, "LuaDLL.luaL_error(l,\"New object failed.\");");
	            Write(file, "return 0;");
                WriteCatchExecption(file);
	            Write(file, "}");
	        }
        }
        else if (t.IsValueType) // default constructor
        {
            WriteFunctionAttr(file);
            Write(file, "static public int constructor(IntPtr l) {");
            WriteTry(file);
            Write(file, "{0} o;", FullName(t));
            Write(file, "o=new {0}();", FullName(t));
            Write(file, "pushValue(l,o);");
            Write(file, "return 1;");
            WriteCatchExecption(file);
            Write(file, "}");
        }
    }

    private void NotSupport(StreamWriter file)
    {
        Write(file, "LuaDLL.luaL_error(l,\"Not support\");");
        Write(file, "return 0;");
    }
    bool IsNotSupport(Type t)
    {
        if (t.IsSubclassOf(typeof(Delegate)))
            return true;
        return false;
    }

    string[] prefix = new string[] { "System.Collections.Generic" };
    string RemoveRef(string s, bool removearray=true)
    {
        if (s.EndsWith("&")) s = s.Substring(0, s.Length - 1);
        if (s.EndsWith("[]") && removearray) s = s.Substring(0, s.Length - 2);
        if (s.StartsWith(prefix[0])) s = s.Substring(prefix[0].Length+1, s.Length - prefix[0].Length-1);
        
        s = s.Replace("+", ".");
        if (s.Contains("`"))
        {
            string regstr = @"`\d";
            Regex r = new Regex(regstr, RegexOptions.None);
            s = r.Replace(s, "");
            s = s.Replace("[", "<");
            s = s.Replace("]", ">");
        }
        return s;
    }

    string GenericBaseName(Type t)
    {
        string n = t.FullName;
        if (n.IndexOf('[')>0)
        {
            n = n.Substring(0, n.IndexOf('['));
        }
        return n.Replace("+", ".");
    }
    string GenericName(Type t)
    {
        try
        {
            Type[] tt = t.GetGenericArguments();
            string ret = "";
            for (int n = 0; n < tt.Length; n++)
            {
                string dt = SimpleType(tt[n]);
                ret += dt;
                if (n < tt.Length - 1)
                    ret += "_";
            }
            return ret;
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
            return "";
        }
    }

    string _Name(string n)
    {
        string ret="";
        for(int i=0;i<n.Length;i++) 
        {
            if(char.IsLetterOrDigit(n[i]))
                ret+=n[i];
            else
                ret += "_";
        }
        return ret;
    }

    string TypeDecl(ParameterInfo[] pars)
    {
        string ret = "";
        for (int n = 0; n < pars.Length; n++)
        {
            ret += ",typeof(";
            ret += SimpleType(pars[n].ParameterType);
            ret += ")";
        }
        return ret;
    }

    bool isUsefullMethod(MethodInfo method)
    {
		if (method.Name != "GetType" && method.Name != "GetHashCode" && method.Name != "Equals" &&
		    method.Name != "ToString" && method.Name != "Clone" && 
		    method.Name != "GetEnumerator" && method.Name != "CopyTo" &&
		    method.Name != "op_Implicit" &&
            !method.Name.StartsWith("get_", StringComparison.Ordinal) &&
            !method.Name.StartsWith("set_", StringComparison.Ordinal) &&
            !method.Name.StartsWith("add_", StringComparison.Ordinal) &&
            !IsObsolete(method) && !method.IsGenericMethod &&
            //!method.Name.StartsWith("op_", StringComparison.Ordinal) &&
            !method.Name.StartsWith("remove_", StringComparison.Ordinal))
        {
            return true;
        }
        return false;
    }

    void WriteFunctionDec(StreamWriter file, string name)
    {
        WriteFunctionAttr(file);
        Write(file, "static public int {0}(IntPtr l) {{", name);
        
    }

    MethodBase[] GetMethods(Type t, string name, BindingFlags bf)
    {
        List<MethodBase> methods = new List<MethodBase>();
        MemberInfo[] cons = t.GetMember(name,bf);
        foreach (MemberInfo m in cons)
        {
            if (m.MemberType == MemberTypes.Method
                && !IsObsolete(m)
                && !DontExport(m)
                && isUsefullMethod((MethodInfo)m) )
                methods.Add((MethodBase)m);
        }
        return methods.ToArray();
    }

    void WriteFunctionImpl(StreamWriter file, MethodInfo m, Type t, BindingFlags bf)
    {
        WriteTry(file);
        MethodBase[] cons = GetMethods(t, m.Name, bf);
        if (cons.Length == 1) // no override function
        {
            if (isUsefullMethod(m) && !m.ReturnType.ContainsGenericParameters && !m.ContainsGenericParameters) // don't support generic method
                WriteFunctionCall(m, file, t);
            else
            {
                Write(file, "LuaDLL.luaL_error(l,\"No matched override function to call\");");
                Write(file, "return 0;");
            }
        }
        else // 2 or more override function
        {
            Write(file, "int argc = LuaDLL.lua_gettop(l);");

            bool first = true;
            for (int n = 0; n < cons.Length; n++)
            {
                if (cons[n].MemberType == MemberTypes.Method)
                {
                    MethodInfo mi = cons[n] as MethodInfo;

                    ParameterInfo[] pars = mi.GetParameters();
                    if (isUsefullMethod(mi) 
                        && !mi.ReturnType.ContainsGenericParameters 
                        /*&& !ContainGeneric(pars)*/) // don't support generic method
                    {
                        if (isUniqueArgsCount(cons, mi))
                            Write(file, "{0}(argc=={1}){{", first ? "if" : "else if", mi.IsStatic?mi.GetParameters().Length:mi.GetParameters().Length+1);
                        else
                            Write(file, "{0}(matchType(l,argc,{1}{2})){{", first ? "if" : "else if", mi.IsStatic ? 1 : 2, TypeDecl(pars));
                        WriteFunctionCall(mi, file, t);
                        Write(file, "}");
                        first = false;
                    }
                }
            }
            Write(file, "LuaDLL.luaL_error(l,\"No matched override function to call\");");
            Write(file, "return 0;");
        }
        WriteCatchExecption(file);
        Write(file, "}");
    }

    bool isUniqueArgsCount(MethodBase[] cons, MethodBase mi)
    {
        foreach (MethodBase member in cons)
        {
            MethodBase m = (MethodBase)member;
            if (m!=mi && mi.GetParameters().Length == m.GetParameters().Length)
                return false;
        }
        return true;
    }

    bool ContainGeneric(ParameterInfo[] pars)
    {
        foreach (ParameterInfo p in pars)
        {
            if (p.ParameterType.IsGenericType || p.ParameterType.IsGenericParameter || p.ParameterType.IsGenericTypeDefinition)
                return true;
        }
        return false;
    }


    void WriteCheckSelf(StreamWriter file, Type t)
    {
        if (t.IsValueType)
        {
            Write(file, "{0} self;",FullName(t));
            Write(file, "checkType(l,1,out self);");
        }
        else
            Write(file, "{0} self=({0})checkSelf(l);", FullName(t));
    }
    private void WriteFunctionCall(MethodInfo m, StreamWriter file, Type t)
    {


        bool hasref = false;
        ParameterInfo[] pars = m.GetParameters();

        int argIndex = 1;
        if (!m.IsStatic)
        {
            WriteCheckSelf(file, t);
            argIndex++;
        }

        


        for (int n=0; n < pars.Length; n++)
        {
            ParameterInfo p = pars[n];
            string pn = p.ParameterType.Name;
            if (pn.EndsWith("&"))
            {
                hasref = true;
            }

            bool hasParams = false;
            if (pars.Length > 0)
                hasParams = pars[n].GetCustomAttributes(typeof(ParamArrayAttribute), false).Length > 0;
            
            CheckArgument(file, p.ParameterType, n, argIndex, p.IsOut, hasParams);
        }

        string ret = "";
        if (m.ReturnType != typeof(void))
        {
			ret = "var ret=";
        }

        if (m.IsStatic)
        {
            if (m.Name == "op_Multiply")
                Write(file, "{0}a1*a2;", ret);
            else if (m.Name == "op_Subtraction")
                Write(file, "{0}a1-a2;", ret);
            else if (m.Name == "op_Addition")
                Write(file, "{0}a1+a2;", ret);
            else if (m.Name == "op_Division")
                Write(file, "{0}a1/a2;", ret);
            else if (m.Name == "op_UnaryNegation")
                Write(file, "{0}-a1;", ret);
            else if (m.Name == "op_Equality")
                Write(file, "{0}(a1==a2);", ret);
            else if (m.Name == "op_Inequality")
                Write(file, "{0}(a1!=a2);", ret);
            else if (m.Name == "op_LessThan")
                Write(file, "{0}(a1<a2);", ret);
            else if (m.Name == "op_GreaterThan")
                Write(file, "{0}(a2<a1);", ret);
            else if (m.Name == "op_LessThanOrEqual")
                Write(file, "{0}(a1<=a2);", ret);
            else if (m.Name == "op_GreaterThanOrEqual")
                Write(file, "{0}(a2<=a1);", ret);
            else
                Write(file, "{3}{2}.{0}({1});", m.Name, FuncCall(m), t.FullName, ret);
        }
        else
            Write(file, "{2}self.{0}({1});", m.Name, FuncCall(m), ret);


        int retcount = 0;
        if (m.ReturnType != typeof(void))
        {

            WritePushValue(m.ReturnType, file);
            retcount = 1;
        }


        // push out/ref value for return value
        if (hasref)
        {
            for (int n = 0; n < pars.Length; n++)
            {
                ParameterInfo p = pars[n];

                if (p.ParameterType.IsByRef)
                {
                    WritePushValue(p.ParameterType, file, string.Format("a{0}", n + 1));
                    retcount++;
                }
            }
        }

        if (t.IsValueType && m.ReturnType == typeof(void) && !m.IsStatic)
            Write(file, "setBack(l,self);");

        Write(file, "return {0};", retcount);


        
    }

    string SimpleType_(Type t)
    {

        string tn = t.Name;

        switch (tn)
        {
            case "Single":
                return "float";
            case "String":
                return "string";
            case "Double":
                return "double";
            case "Boolean":
                return "bool";
            case "Int32":
                return "int";
            case "Object":
                return FullName(t);
            default:
                tn = TypeDecl(t);
                tn = tn.Replace("System.Collections.Generic.", "");
                tn = tn.Replace("System.Object", "object");
                return tn;
        }
    }

    string SimpleType(Type t)
    {
        string ret = SimpleType_(t);
        return ret;
    }

    void WritePushValue(Type t, StreamWriter file)
    {
        if(t.IsEnum)
            Write(file, "pushEnum(l,(int)ret);");
        else
            Write(file, "pushValue(l,ret);");
    }

    void WritePushValue(Type t, StreamWriter file, string ret)
    {
        if(t.IsEnum)
            Write(file, "pushEnum(l,(int){0});", ret);
        else
            Write(file, "pushValue(l,{0});", ret);
    }


    void Write(StreamWriter file, string fmt, params object[] args)
    {
        if (fmt.StartsWith("}")) indent--;

        for (int n = 0; n < indent; n++)
            file.Write("\t");


        if (args.Length == 0)
            file.WriteLine(fmt);
        else
        {
            string line = string.Format(fmt, args);
            file.WriteLine(line);
        }

        if (fmt.EndsWith("{")) indent++;
    }

    private void CheckArgument(StreamWriter file, Type t, int n,int argstart, bool isout, bool isparams)
    {
        Write(file, "{0} a{1};", TypeDecl(t), n + 1);

        if (!isout)
        {
            if (t.IsEnum)
                Write(file, "checkEnum(l,{0},out a{1});", n + argstart, n + 1);
            else if (t.BaseType == typeof(System.MulticastDelegate))
            {
                tryMake(t);
                Write(file, "LuaDelegation.checkDelegate(l,{0},out a{1});", n + argstart, n + 1);
            }
            else if (isparams)
                Write(file, "checkParams(l,{0},out a{1});", n + argstart, n + 1);
            else
                Write(file, "checkType(l,{0},out a{1});", n + argstart, n + 1);
        }
    }

    string FullName(string str)
    {
        if (str == null)
        {
            throw new NullReferenceException();
        }
        return RemoveRef(str.Replace("+", "."));
    }

    string TypeDecl(Type t)
    {
        if (t.IsGenericType)
        {
            string ret =  GenericBaseName(t);

			string gs = "";
            gs += "<";
            Type[] types = t.GetGenericArguments();
            for (int n = 0; n < types.Length; n++)
            {
                gs += TypeDecl(types[n]);
                if(n<types.Length-1)
                    gs += ",";
            }
            gs += ">";

			ret = Regex.Replace(ret,@"`\d",gs);

            return ret;
        }
        else
            return RemoveRef(t.ToString(), false);
    }

    string ExportName(Type t)
    {
        string name = RemoveRef(t.FullName, true);
        name = "Lua_" + name;
        return name.Replace(".", "_");
    }

    string FullName(Type t)
    {
        if (t.FullName == null)
        {
            Debug.Log(t.Name);
            return t.Name;
        }
        return FullName(t.FullName);
    }

    string FuncCall(MethodBase m)
    {

        string str = "";
        ParameterInfo[] pars = m.GetParameters();
        for (int n = 0; n < pars.Length; n++)
        {
            ParameterInfo p = pars[n];
            if (p.ParameterType.IsByRef && p.IsOut)
                str += string.Format("out a{0}", n + 1);
            else if (p.ParameterType.IsByRef)
                str += string.Format("ref a{0}", n + 1);
            else
                str += string.Format("a{0}", n + 1);
            if (n < pars.Length - 1)
                str += ",";
        }
        return str;
    }

}
