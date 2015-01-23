using UnityEngine;
using System.Collections;
using SLua;
public class LuaSvrGameObject : MonoBehaviour {

    public LuaState state;

    // make sure lua state finalize at last
    // make sure LuaSvrGameObject excute order is max(9999)
    void OnDestroy()
    {
        if (state != null)
        {
            state.Close();
        }
    }
}
