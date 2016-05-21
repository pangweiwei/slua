
echo Install nuget.exe first!!!

nuget install NUnit.Runners -Version 2.6.4 -OutputDirectory %~dp0
%~dp0\NUnit.Runners.2.6.4\tools\nunit-console-x86.exe %~dp0\bin\slua-standalone-tests.dll
