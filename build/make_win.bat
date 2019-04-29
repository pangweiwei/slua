mkdir build_win32 & pushd build_win32
cmake -G "Visual Studio 15 2017" ..
popd
cmake --build build_win32 --config Release
copy /Y build_win32\Release\slua.dll ..\Assets\Plugins\x86\slua.dll

mkdir build_win64 & pushd build_win64
cmake -G "Visual Studio 15 2017 Win64" ..
popd
cmake --build build_win64 --config Release
copy /Y build_win64\Release\slua.dll ..\Assets\Plugins\x64\slua.dll