mkdir -p build_osx && cd build_osx
cmake -GXcode ..
cd ..

cmake --build build_osx --config Release
cp -r build_osx/Release/slua.bundle ../Assets/Plugins/