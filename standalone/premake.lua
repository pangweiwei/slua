
solution "slua-standalone"
    configurations { 
        "Debug_Windows", "Debug_Linux", 
        "Release_Windows", "Release_Linux"
    }
    location ("./" .. (_ACTION or ""))
    debugdir ("./bin")
    debugargs {  }

configuration "Debug_Windows"
    flags { "Symbols" }
    defines { "_DEBUG", "DEBUG", "TRACE", "SLUA_STANDALONE_WINDOWS" }
configuration "Debug_Linux"
    flags { "Symbols" }
    defines { "_DEBUG", "DEBUG", "TRACE", "SLUA_STANDALONE_LINUX" }
configuration "Release_Windows"
    flags { "Optimize" }
    defines { "SLUA_STANDALONE_WINDOWS" }
configuration "Release_Linux"
    flags { "Optimize" }
    defines { "SLUA_STANDALONE_LINUX" }
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
