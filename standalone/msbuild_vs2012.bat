set MSBUILD="C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe"
set PROJECT="%~dp0vs2012\slua-standalone.sln"

set BIN_PATH="%~dp0bin"

cmd /c %~dp0premake.bat

%MSBUILD% %PROJECT% /property:Configuration="Release";GenerateDocumentation=true;DeployOnBuild=true;PublishProfile=Deployment' /property:Platform="Any CPU" /target:Rebuild /nologo /verbosity:normal


:: Copy luajit.dll and .so

:: 32bit on windows
copy /Y %~dp0..\Assets\Plugins\x86\slua.dll %BIN_PATH%

:: 64bit on linux mono
copy /Y %~dp0..\Assets\Plugins\x64\slua.so %BIN_PATH%

copy /Y %~dp0linux.slua-standalone.dll.config %BIN_PATH%\slua-standalone.dll.config


echo On Linux: > %BIN_PATH%\README
echo command  `export LD_LIBRARY_PATH=$PWD` make the library can be searched >> %BIN_PATH%\SLUA_README.txt
