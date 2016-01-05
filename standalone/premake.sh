BASE=$(cd `dirname $0`; pwd)
cd $BASE
#../tools/premake5 --file=premake.lua vs2012
#../tools/premake5 --file=premake.lua vs2013
../tools/premake5 --file=premake.lua gmake
