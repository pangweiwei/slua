cmake_minimum_required(VERSION 2.8)

set(CMAKE_BUILD_TYPE Release)

project(slua)

set(EXT_SRC_ROOT ./)
set(LUA_INC_PATH ${EXT_SRC_ROOT}/lua-5.1.5/src)
set(LUA_SRC_PATH ${EXT_SRC_ROOT}/lua-5.1.5/src)
set(SLUA_SRC_PATH ${EXT_SRC_ROOT}/slua.c)

set(LUA_SRC_FILES 
    ${LUA_SRC_PATH}/lapi.c
    ${LUA_SRC_PATH}/lauxlib.c
    ${LUA_SRC_PATH}/lbaselib.c
    ${LUA_SRC_PATH}/lcode.c
    ${LUA_SRC_PATH}/ldblib.c
    ${LUA_SRC_PATH}/ldebug.c
    ${LUA_SRC_PATH}/ldo.c
    ${LUA_SRC_PATH}/ldump.c
    ${LUA_SRC_PATH}/lfunc.c
    ${LUA_SRC_PATH}/lgc.c
    ${LUA_SRC_PATH}/linit.c
    ${LUA_SRC_PATH}/liolib.c
    ${LUA_SRC_PATH}/llex.c
    ${LUA_SRC_PATH}/lmathlib.c
    ${LUA_SRC_PATH}/lmem.c
    ${LUA_SRC_PATH}/loadlib.c
    ${LUA_SRC_PATH}/lobject.c
    ${LUA_SRC_PATH}/lopcodes.c
    ${LUA_SRC_PATH}/loslib.c
    ${LUA_SRC_PATH}/lparser.c
    ${LUA_SRC_PATH}/lstate.c
    ${LUA_SRC_PATH}/lstring.c
    ${LUA_SRC_PATH}/lstrlib.c
    ${LUA_SRC_PATH}/ltable.c
    ${LUA_SRC_PATH}/ltablib.c
    ${LUA_SRC_PATH}/ltm.c
    ${LUA_SRC_PATH}/lundump.c
    ${LUA_SRC_PATH}/lvm.c
    ${LUA_SRC_PATH}/lzio.c
    ${SLUA_SRC_PATH}
)

set(THIRDPART_INC_PATH "")
set(THIRDPART_SRC_FILES "")

#being third-party

#being lua socket
set(LUA_SOCKET_INC_PATH ${EXT_SRC_ROOT}/luasocket-mini)
set(LUA_SOCKET_SRC_PATH ${EXT_SRC_ROOT}/luasocket-mini)

IF(WIN32)
set (LUA_SOCKET_SRC_SOCKET_FILES
    ${LUA_SOCKET_SRC_PATH}/wsocket.c
    ${LUA_SOCKET_SRC_PATH}/wsocket.h
)
ELSE()
set (LUA_SOCKET_SRC_SOCKET_FILES
    ${LUA_SOCKET_SRC_PATH}/usocket.c
    ${LUA_SOCKET_SRC_PATH}/usocket.h
)
ENDIF()

set (LUA_SOCKET_SRC_FILES
    ${LUA_SOCKET_SRC_PATH}/auxiliar.c
    ${LUA_SOCKET_SRC_PATH}/auxiliar.h
    ${LUA_SOCKET_SRC_PATH}/buffer.c
    ${LUA_SOCKET_SRC_PATH}/buffer.h
    ${LUA_SOCKET_SRC_PATH}/except.c
    ${LUA_SOCKET_SRC_PATH}/except.h
    ${LUA_SOCKET_SRC_PATH}/inet.c
    ${LUA_SOCKET_SRC_PATH}/inet.h
    ${LUA_SOCKET_SRC_PATH}/io.c
    ${LUA_SOCKET_SRC_PATH}/io.h
    ${LUA_SOCKET_SRC_PATH}/luasocket.c
    ${LUA_SOCKET_SRC_PATH}/luasocket.h
    ${LUA_SOCKET_SRC_PATH}/options.c
    ${LUA_SOCKET_SRC_PATH}/options.h
    ${LUA_SOCKET_SRC_PATH}/select.c
    ${LUA_SOCKET_SRC_PATH}/socket.h
    ${LUA_SOCKET_SRC_PATH}/tcp.c
    ${LUA_SOCKET_SRC_PATH}/tcp.h
    ${LUA_SOCKET_SRC_PATH}/timeout.c
    ${LUA_SOCKET_SRC_PATH}/timeout.h
    ${LUA_SOCKET_SRC_PATH}/udp.c
    ${LUA_SOCKET_SRC_PATH}/udp.h
    ${LUA_SOCKET_SRC_PATH}/compat.c
    ${LUA_SOCKET_SRC_PATH}/compat.h
    ${LUA_SOCKET_SRC_SOCKET_FILES}
)
#end lua socket

set(THIRDPART_INC_PATH ${THIRDPART_INC_PATH} ${LUA_SOCKET_INC_PATH})
set(THIRDPART_SRC_FILES ${THIRDPART_SRC_FILES} ${LUA_SOCKET_SRC_FILES})
#end third-party

include_directories(
    ${LUA_INC_PATH}
    ${THIRDPART_INC_PATH}
)

if(APPLE)
    if(IOS)
        set(CMAKE_OSX_ARCHITECTURES "$(ARCHS_STANDARD)")
    else()
        set(CMAKE_OSX_ARCHITECTURES "$(ARCHS_STANDARD_64_BIT)")
    endif()
endif()

if(APPLE)

if(IOS) # on iOS
add_library(slua 
    ${LUA_SRC_FILES}
    ${THIRDPART_SRC_FILES}
)
else() # on MACOS
add_library(slua MODULE
    ${LUA_SRC_FILES}
    ${THIRDPART_SRC_FILES}
)
set_target_properties(slua PROPERTIES BUNDLE TRUE)
endif()

else()
add_library(slua SHARED
    ${LUA_SRC_FILES}
    ${THIRDPART_SRC_FILES}
)
endif()

if(UNIX)
target_link_libraries(slua m)
elseif(WIN32)
target_link_libraries(slua Ws2_32)
add_compile_definitions(LUA_BUILD_AS_DLL)
endif()