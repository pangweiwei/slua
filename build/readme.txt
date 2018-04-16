编译各种环境的jit代码，采用luajit2.1-beta3

实在没法在IOS的bundle里面使用luajit.在OSX64位模式下，只能用GC64

为了支持远程调试，集成了luasocket，仅包含socket库，扩展的ftp,smtp等库没有集成
