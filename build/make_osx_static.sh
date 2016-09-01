#!/usr/bin/env bash

cd "$( dirname "${BASH_SOURCE[0]}" )"
cp slua.c lua-5.1.5/src/

cd lua-5.1.5
make clean
make CC="gcc -m32" BUILDMODE=static PLAT=macosx
cp src/liblua.a ../lua-5.1.5/liblua_x86.a

make clean
make CC="gcc" BUILDMODE=static PLAT=macosx
cp src/liblua.a ../lua-5.1.5/liblua_x86_64.a

lipo -create ../lua-5.1.5/liblua_x86.a ../lua-5.1.5/liblua_x86_64.a -output ../bin/osx/libslua.a
