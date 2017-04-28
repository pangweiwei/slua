@echo off

setlocal

set LLIBNAME=lua51.lib
set LDLLNAME=lua51.dll
set LLINK=link /nologo
set LCOMPILE=cl /nologo /c /O2 /W3 /D_CRD_SECURE_NO_DEPRECATE /D_CRT_SECURE_NO_WARNINGS /DLUA_BUILD_AS_DLL /wd4334

Rem build lua.dll
%LCOMPILE% l*.c slua.c
del lua.obj luac.obj
%LLINK% /DLL /out:%LDLLNAME% l*.obj slua.obj

Rem Delete object files
del *.obj
