#!/usr/bin/env bash
cd "$( dirname "${BASH_SOURCE[0]}" )"
cp slua.c LuaJIT-2.1.0/src/
cd LuaJIT-2.1.0
SRCDIR=$(pwd)
DIR=$(pwd)

${NDKPATH?"Need to set NDKPATH"}

NDK=$NDKPATH
NDKABI=8
NDKVER=$NDK/toolchains/arm-linux-androideabi-4.8
NDKP=$NDKVER/prebuilt/darwin-x86_64/bin/arm-linux-androideabi-
NDKF="--sysroot $NDK/platforms/android-$NDKABI/arch-arm"

# # Android/ARM, armeabi (ARMv5TE soft-float), Android 2.2+ (Froyo)
# DESTDIR=$DIR/android/armeabi
# mkdir -p $DESTDIR
# rm -rf "$DESTDIR"/*.a
# make clean
# make HOST_CC="gcc -m32" CROSS=$NDKP TARGET_SYS=Linux TARGET_FLAGS="$NDKF"

# if [ -f $SRCDIR/src/libluajit.so ]; then
#     mv $SRCDIR/src/libluajit.so $DESTDIR/libslua.so
# fi;

# Android/ARM, armeabi-v7a (ARMv7 VFP), Android 4.0+ (ICS)
NDKARCH="-march=armv7-a -mfloat-abi=softfp -Wl,--fix-cortex-a8"
NDKABI=14
NDKF="--sysroot $NDK/platforms/android-$NDKABI/arch-arm"
DESTDIR=$DIR/android/armeabi-v7a
mkdir -p $DESTDIR
rm -rf "$DESTDIR"/*.a
make clean
make HOST_CC="gcc -m32" CROSS=$NDKP TARGET_SYS=Linux TARGET_FLAGS="$NDKF $NDKARCH" TARGET_SONAME=libslua.so BUILDMODE=dynamic

if [ -f $SRCDIR/src/libluajit.so ]; then
    cp $SRCDIR/src/libluajit.so ../../Assets/Plugins/Android/libs/armeabi-v7a/libslua.so
fi;

# Android/x86, x86 (i686 SSE3), Android 4.0+ (ICS)
NDKABI=14
DESTDIR=$DIR/android/x86
mkdir -p $DESTDIR
NDKVER=$NDK/toolchains/x86-4.8
NDKP=$NDKVER/prebuilt/darwin-x86_64/bin/i686-linux-android-
NDKF="--sysroot $NDK/platforms/android-$NDKABI/arch-x86"
rm -rf "$DESTDIR"/*.a
make clean
make HOST_CC="gcc -m32" CROSS=$NDKP TARGET_SYS=Linux TARGET_FLAGS="$NDKF"

if [ -f $SRCDIR/src/libluajit.so ]; then
    cp $SRCDIR/src/libluajit.so ../../Assets/Plugins/Android/libs/x86/libslua.so
fi;

# make clean
