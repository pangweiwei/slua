cd $(cd `dirname $0`; pwd)
./premake.sh

cd gmake
make config=release_linux

echo 'Copying NUnit.dll'
cp ../packages/NUnit.3.0.1/lib/net20/*.dll ../bin/

echo 'Copying slua.so'
cp ../../Assets/Plugins/x64/slua.* ../bin/

echo 'Success!'

