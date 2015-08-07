#!/usr/bin/env bash
cd "$( dirname "${BASH_SOURCE[0]}" )"

cd lua-5.1.5/slua
xcodebuild
cp -r Build/Release/slua.bundle ../../../Assets/Plugins/

cd -