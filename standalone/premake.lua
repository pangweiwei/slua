
solution "slua-standalone"
    configurations {
        "Debug", "Release"
    }

    location ("./" .. (_ACTION or ""))
    debugdir ("./bin")
    debugargs {  }

    platforms { "Any CPU" }

    --filter "platforms:x64"
      --architecture "x64"

    --filter "platforms:x32"
      --architecture "x32"
configuration "Debug"
    symbols "on"
    clr "unsafe" 
    defines { "_DEBUG", "DEBUG", "TRACE" }
configuration "Release"
    optimize "on"
    clr "unsafe" 
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
    "../build/BytesHelper.cs",
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
     "./packages/NUnit.2.6.4/lib/nunit.framework.dll",
}

project "slua-standalone-demo"
language "C#"
kind "ConsoleApp"
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
     "./packages/NUnit.2.6.4/lib/nunit.framework.dll",
}
