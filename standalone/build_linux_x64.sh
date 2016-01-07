cd $(cd `dirname $0`; pwd)

# premake has bug with different platform (centos / ubuntu) 
# so manually generate project and commit it please
#./premake.sh

cd gmake
make config=release

echo 'Copying NUnit.dll...'
cp ../packages/NUnit.3.0.1/lib/net20/*.dll ../bin/

echo 'Copying slua.so & slua.dll...'
cp ../../Assets/Plugins/x64/slua.* ../bin/

echo 'Copying dll config...'
cp -f ../linux.slua-standalone.dll.config ../bin/slua-standalone.dll.config

echo 'Success!'

