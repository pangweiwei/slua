extern "C" {
    #include "lua.h"
    #include "lualib.h"
    #include "lauxlib.h"
}


void hook (lua_State *L, lua_Debug *ar) {

}

int main() {
    lua_State* L = lua_open();
    luaL_openlibs(L);
    FILE* fp = fopen("test.lua","r");
    fseek(fp,-1,SEEK_END);
    long size = ftell(fp);
    fseek(fp,0,SEEK_SET);
    char script[size+1];
    fread(script,size,1,fp);
    script[size]=0;
    fclose(fp);
    
    lua_sethook(L,hook,LUA_MASKCALL,0);
    if(luaL_dostring(L,script)!=0) {
        printf("error:%s\n",lua_tostring(L,-1));
    }

    return 0;
}