BASE=$(cd `dirname $0`; pwd)
cd $BASE
#../tools/premake5 --file=premake.lua vs2012
#../tools/premake5 --file=premake.lua vs2013
OS=$(uname)
if [ $OS=="Darwin" ]; then
    ../tools/premake5_mac --file=premake.lua gmake
else
    ../tools/premake5 --file=premake.lua gmake
fi
