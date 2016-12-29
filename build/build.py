#!/usr/bin/env python2.7
# coding=utf-8

import subprocess
import platform
import os
import sys
import stat

def build(platform):
    print("[Start Build] Target Platform: " + platform)
    build_folder = os.path.split(os.path.realpath(__file__))[0]
    #change folder
    os.chdir(build_folder)

    build_script = ""
    build_cmd = ""
    if platform == "windows":
        build_script = "make_win_with_2015_static.bat"
        build_cmd = ["cmd.exe","/C",build_script]
    elif platform == "android":
        build_script = "make_android_static.sh"
        build_cmd = ["sh",build_script]
    elif platform == "ios":
        build_script = "make_ios.sh"
        build_cmd = ["sh",build_script]
    elif platform == "osx":
        build_script = "make_osx_static.sh"
        build_cmd = ["sh",build_script]

    #make script execute able
    #chmod a+x
    st = os.stat(build_script)
    os.chmod(build_script, st.st_mode | stat.S_IXUSR | stat.S_IXGRP | stat.S_IXOTH)
    subprocess.check_call(build_cmd,shell=True)

if __name__ == '__main__':
    length = len(sys.argv)
    if length < 2:
        sys.exit("please select target platform !")

    platform = sys.argv[1]
    build(platform)
    # print(platform)
