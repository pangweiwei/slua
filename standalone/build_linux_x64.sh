cd $(cd `dirname $0`; pwd)
./premake.sh

cd gmake
make config=release_linux

echo 'Copying NUnit.dll...'
cp ../packages/NUnit.3.0.1/lib/net20/*.dll ../bin/

echo 'Copying slua.so & slua.dll...'
cp ../../Assets/Plugins/x64/slua.* ../bin/

echo 'Copying dll config...'
cp ./slua-standalone.dll.config ../bin/

echo 'Success!'

