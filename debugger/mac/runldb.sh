#!/bin/sh
export workDir=`pwd`
osascript -e "tell app \"Terminal\" 
activate
do script \"$workDir/ldb -host $1 -port $2 \"
end tell"
