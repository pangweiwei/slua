@echo off
copy /Y slua.c luajit-2.0.4\src\ 
if exist "%VS120COMNTOOLS%" (
	set VCVARS="%VS120COMNTOOLS%..\..\VC\bin\"
	goto build
	) 
else (goto check2012)

:check2012
if exist "%VS110COMNTOOLS%" (set VCVARS="%VS110COMNTOOLS%..\..\VC\bin\") else (goto missing)

:build

@set ENV32="%VCVARS%vcvars32.bat"
@set ENV64="%VCVARS%amd64\vcvars64.bat"

call "%ENV32%"
echo Swtich to x86 build env
cd luajit-2.0.4\src
call msvcbuild.bat
copy /Y lua51.dll ..\..\..\Assets\Plugins\x86\slua.dll
cd ..\..

call "%ENV64%"
echo Swtich to x64 build env
cd luajit-2.0.4\src
call msvcbuild.bat
copy /Y lua51.dll ..\..\..\Assets\Plugins\x64\slua.dll
cd ..\..


goto :eof

:missing
echo Can't find Visual Studio 2013.
goto :eof