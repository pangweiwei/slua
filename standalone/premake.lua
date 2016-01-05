
solution "slua-standalone"
    configurations { 
        "Debug", "Release"
    }
    location ("./" .. (_ACTION or ""))
    debugdir ("./bin")
    debugargs {  }

configuration "Debug"
    flags { "Symbols" }
    defines { "_DEBUG", "DEBUG", "TRACE" }
configuration "Release"
    flags { "Optimize" }
configuration "vs*"
    defines { "" }

project "slua-standalone"
language "C#"
kind "SharedLib"
framework "3.5"
targetdir "./bin"

files
{
    "../Assets/Plugins/Slua_Managed/**.cs",
}

defines
{
	"SLUA_STANDALONE", 
	"UNITY_STANDALONE_WIN",  -- sim unity pc
	"UNITY_STANDALONE",
}

links
{
    "System",
    "System.Core",

}

project "slua-standalone-tests"
language "C#"
kind "SharedLib"
framework "3.5"
targetdir "./bin"

files
{
    "./slua-standalone-tests/**.cs",
}

defines
{
}

links
{
    "slua-standalone",
    "System",
     "./packages/NUnit.3.0.1/lib/net20/nunit.framework.dll",
}
