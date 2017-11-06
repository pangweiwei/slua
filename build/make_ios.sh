#!/usr/bin/env bash
cd "$( dirname "${BASH_SOURCE[0]}" )"
cp slua.c luasocket-mini/* luajit-2.1.0-beta3/src/
cd luajit-2.1.0-beta3


LIPO="xcrun -sdk iphoneos lipo"
STRIP="xcrun -sdk iphoneos strip"


IXCODE=`xcode-select -print-path`
ISDK=$IXCODE/Platforms/iPhoneOS.platform/Developer
ISDKVER=iPhoneOS.sdk
# set development target to 8.0
DEVTAR=8.0
ISDKP=$IXCODE/usr/bin/

if [ ! -e $ISDKP/ar ]; then
  sudo cp /usr/bin/ar $ISDKP
fi

if [ ! -e $ISDKP/ranlib ]; then
  sudo cp /usr/bin/ranlib $ISDKP
fi

if [ ! -e $ISDKP/strip ]; then
  sudo cp /usr/bin/strip $ISDKP
fi

make clean
ISDKF="-arch armv7 -isysroot $ISDK/SDKs/$ISDKVER -miphoneos-version-min=$DEVTAR"
make HOST_CC="gcc -m32 -std=c99" CROSS="$ISDKP" TARGET_FLAGS="$ISDKF" TARGET=armv7 TARGET_SYS=iOS LUAJIT_A=libsluav7.a

make clean
ISDKF="-arch armv7s -isysroot $ISDK/SDKs/$ISDKVER -miphoneos-version-min=$DEVTAR"
make HOST_CC="gcc -m32 -std=c99" CROSS="$ISDKP" TARGET_FLAGS="$ISDKF" TARGET=armv7s TARGET_SYS=iOS LUAJIT_A=libsluav7s.a

make clean
ISDKF="-arch arm64 -isysroot $ISDK/SDKs/$ISDKVER -miphoneos-version-min=$DEVTAR"
make HOST_CC="gcc -std=c99" CROSS="$ISDKP" TARGET_FLAGS="$ISDKF" TARGET=arm64 TARGET_SYS=iOS LUAJIT_A=libslua64.a

# add simulator support
ISDK=$IXCODE/Platforms/iPhoneSimulator.platform/Developer
ISDKVER=iPhoneSimulator.sdk
set development target to 8.0
DEVTAR=9.0
ISDKP=/usr/bin/

make clean
ISDKF="-arch i386 -isysroot $ISDK/SDKs/$ISDKVER -mios-simulator-version-min=$DEVTAR"
make HOST_CC="gcc -m32 -arch i386" CROSS=$ISDKP TARGET_FLAGS="$ISDKF" TARGET=i386 TARGET_SYS=iOS  LUAJIT_A=libluajit-i386.a


make clean
ISDKF="-arch x86_64 -isysroot $ISDK/SDKs/$ISDKVER -mios-simulator-version-min=$DEVTAR"
make HOST_CC="gcc -m64 -arch x86_64" CROSS=$ISDKP TARGET_FLAGS="$ISDKF" TARGET=x86_64 TARGET_SYS=iOS  LUAJIT_A=libluajit-x86_64.a CFLAGS=-DLUAJIT_ENABLE_GC64

cd src
lipo libsluav7.a -create libsluav7s.a libslua64.a libluajit-i386.a libluajit-x86_64.a -output libslua.a
#lipo libsluav7.a -create libsluav7s.a libslua64.a -output libslua.a

cp libslua.a ../../../Assets/Plugins/iOS/

cd ..