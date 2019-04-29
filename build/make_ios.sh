mkdir -p build_ios && cd build_ios
cmake -DCMAKE_TOOLCHAIN_FILE=../cmake/iOS.cmake  -GXcode ../
cd ..

cmake --build build_ios --config Release
cp build_ios/Release-iphoneos/libslua.a ../Assets/Plugins/iOS/libslua.a