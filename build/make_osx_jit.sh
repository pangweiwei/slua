#!/usr/bin/env bash

cd "$( dirname "${BASH_SOURCE[0]}" )"
cp slua.c luajit-2.1.0/src/

cd luajit-2.1.0
make clean
make CC="gcc -m32" BUILDMODE=static
cp src/libluajit.a ../luajit-osx/libluajit_x86.a

make clean
make CC="gcc" BUILDMODE=static
cp src/libluajit.a ../luajit-osx/libluajit_x86_64.a

cd ../luajit-osx/
xcodebuild -configuration=Release
cp -r Build/Release/slua.bundle ../../Assets/Plugins/
