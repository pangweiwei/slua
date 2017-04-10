@echo off
copy /Y slua.c luajit-2.0.4\src\ 
if exist "%VS140COMNTOOLS%" (
	set VCVARS="%VS140COMNTOOLS%..\..\VC\bin\"
	goto build
	) 
else (goto check2013)

:check2013
if exist "%VS120COMNTOOLS%" (set VCVARS="%VS120COMNTOOLS%..\..\VC\bin\") else (goto check2012)

:check2012
if exist "%VS110COMNTOOLS%" (set VCVARS="%VS110COMNTOOLS%..\..\VC\bin\") else (goto missing)

:build

@set ENV32="%VCVARS%vcvars32.bat"
@set ENV64="%VCVARS%amd64\vcvars64.bat"

call "%ENV32%"
echo Swtich to x86 build env
cd luajit-2.0.4\src

echo Build Debug
call msvcbuild.bat debug static
@set OUTPUTDIR=..\..\bin\x86\Debug
if not exist "%OUTPUTDIR%" mkdir "%OUTPUTDIR%"
copy /Y lua51.lib %OUTPUTDIR%\sluad.lib
echo Build Release
call msvcbuild.bat static
@set OUTPUTDIR=..\..\bin\x86\Release
if not exist "%OUTPUTDIR%" mkdir "%OUTPUTDIR%"
copy /Y lua51.lib %OUTPUTDIR%\slua.lib
cd ..\..

call "%ENV64%"
echo Swtich to x64 build env
cd luajit-2.0.4\src
echo Build Debug
call msvcbuild.bat debug static
@set OUTPUTDIR=..\..\bin\x64\Debug
if not exist "%OUTPUTDIR%" mkdir "%OUTPUTDIR%"
copy /Y lua51.lib %OUTPUTDIR%\sluad.lib
echo Build Release
call msvcbuild.bat static
@set OUTPUTDIR=..\..\bin\x64\Release
if not exist "%OUTPUTDIR%" mkdir "%OUTPUTDIR%"
copy /Y lua51.lib %OUTPUTDIR%\slua.lib
cd ..\..


goto :eof

:missing
echo Can't find Visual Studio 2013.
goto :eof
