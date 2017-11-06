@echo off

:: lua paths define
set LUAJIT_PATH=luajit-2.1.0-beta3
set STANDARD_LUA_PATH=lua-5.1.5

:: deciding whether to use luajit or not
:: set USE_STANDARD_LUA=%1%
set USE_LUA_PATH=%LUAJIT_PATH%
:: if "%USE_STANDARD_LUA%"=="YES" (set USE_LUA_PATH=%STANDARD_LUA_PATH%)

:: get visual studio tools path
:check2015
if exist "%VS130COMNTOOLS%" (
    set VS_TOOL_VER=vs130
    set VCVARS="%VS130COMNTOOLS%..\..\VC\bin\"
    goto build
)
:check2013
if exist "%VS120COMNTOOLS%" (
    set VS_TOOL_VER=vs120
    set VCVARS="%VS120COMNTOOLS%..\..\VC\bin\"
    goto build
)
:check2012
if exist "%VS110COMNTOOLS%" (
    set VS_TOOL_VER=vs110
    set VCVARS="%VS110COMNTOOLS%..\..\VC\bin\"
    goto build
)
:check2010
if exist "%VS100COMNTOOLS%" (
    set VS_TOOL_VER=vs100
    set VCVARS="%VS100COMNTOOLS%..\..\VC\bin\"
    goto build
)
:check2008
if exist "%VS90COMNTOOLS%" (
    set VS_TOOL_VER=vs90
    set VCVARS="%VS90COMNTOOLS%..\..\VC\bin\"
    goto build
)
else (
    goto missing
)

:build
set ENV32="%VCVARS%vcvars32.bat"
set ENV64="%VCVARS%amd64\vcvars64.bat"

copy /Y slua.c "%USE_LUA_PATH%\src\"
copy /Y luasocket-mini\*.* "%USE_LUA_PATH%\src\"

call "%ENV32%"
echo Swtich to x86 build env(%VS_TOOL_VER%)
cd %USE_LUA_PATH%\src
call msvcbuild.bat
copy /Y lua51.dll ..\..\..\Assets\Plugins\x86\slua.dll
copy /Y lua51.dll ..\..\..\jit\win\x86\lua51.dll
copy /Y luajit.exe ..\..\..\jit\win\x86\luajit.exe
cd ..\..



goto :eof

:missing
echo Can't find Visual Studio, compilation fails!

goto :eof
