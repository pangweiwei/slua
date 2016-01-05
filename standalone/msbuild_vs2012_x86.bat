set MSBUILD="C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe"
set PROJECT="%~dp0vs2012\slua-standalone.sln"

set BIN_PATH="%~dp0bin"

cmd /c %~dp0premake.bat

%MSBUILD% %PROJECT% /property:Configuration="Release";GenerateDocumentation=true;DeployOnBuild=true;PublishProfile=Deployment' /target:Rebuild /nologo /verbosity:normal


:: Copy luajit.dll and .so
set BIN_TYPE="x86"

copy /Y %~dp0..\Assets\Plugins\%BIN_TYPE%\slua.dll %BIN_PATH%
copy /Y %~dp0..\Assets\Plugins\%BIN_TYPE%\slua.so %BIN_PATH%
