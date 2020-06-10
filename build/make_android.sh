if [ -z "$NDKPATH" ]; then
    echo "Android NDK not detected'"
    exit 1
fi

# build armv7a
mkdir -p build_android_v7a && cd build_android_v7a
cmake -DANDROID_ABI=armeabi-v7a -DCMAKE_TOOLCHAIN_FILE=../cmake/android.toolchain.cmake -DANDROID_TOOLCHAIN_NAME=arm-linux-androideabi-4.9 -DANDROID_NATIVE_API_LEVEL=android-9 ..
cd ..
cmake --build build_android_v7a --config Release
cp build_android_v7a/libslua.so ../Assets/Plugins/Android/libs/armeabi-v7a/libslua.so

# build arm64
mkdir -p build_android_arm64 && cd build_android_arm64
cmake -DANDROID_ABI=arm64-v8a -DCMAKE_TOOLCHAIN_FILE=../cmake/android.toolchain.cmake -DANDROID_TOOLCHAIN_NAME=aarch64-linux-android-4.9 -DANDROID_NATIVE_API_LEVEL=android-21 ..
cd ..
cmake --build build_android_arm64 --config Release
cp build_android_arm64/libslua.so ../Assets/Plugins/Android/libs/armeabi-arm64/libslua.so

# build x86
mkdir -p build_android_x86 && cd build_android_x86
cmake -DANDROID_ABI=x86 -DCMAKE_TOOLCHAIN_FILE=../cmake/android.toolchain.cmake -DANDROID_TOOLCHAIN_NAME=x86-4.9 -DANDROID_NATIVE_API_LEVEL=android-9 ..
cd ..
cmake --build build_android_x86 --config Release
cp build_android_x86/libslua.so ../Assets/Plugins/Android/libs/x86/libslua.so