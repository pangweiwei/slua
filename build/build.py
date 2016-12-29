#!/usr/bin/env python2.7
# coding=utf-8

import subprocess
import platform
import os
import sys
def build(platform):
    print("[Start Build] Target Platform: " + platform)
    build_script = ""
    if platform == "windows":
        build_script = "make_win_with_2015_static.bat"
    elif platform == "android":
        build_script = "make_android_static.sh"
    elif platform == "ios":
        build_script = "make_ios.sh"
    elif platform == "osx":
        build_script = "make_osx_static.sh"
    subprocess.check_call("make_android_static.sh",shell=True)

if __name__ == '__main__':
    length = len(sys.argv)
    if length < 2:
        sys.exit("please select target platform !")

    platform = sys.argv[1]
    build(platform)
    # print(platform)
