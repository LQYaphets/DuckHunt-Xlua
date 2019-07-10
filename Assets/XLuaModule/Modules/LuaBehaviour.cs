
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using XLua;
using System;

[System.Serializable]
public class Injection
{
    public string name;
    public GameObject value;
}

namespace LQQ
{
    [LuaCallCSharp]
    public class LuaBehaviour : MonoBehaviour
    {
        public TextAsset LuaScript;
        public Injection[] Injections;
        internal static LuaEnv luaEnv = new LuaEnv(); //all lua behaviour shared one luaenv only!
        internal static float lastGCTime = 0;
        internal const float GCInterval = 1; //1 second 
        private Action luaStart;
        private Action luaUpdate;
        private Action luaOnDestroy;
        private Action luaOnEnable;
        private Action luaOnDisAble;
        private Action luaFixUpdate;
        private Action luaLateUpdate;
        private LuaTable scriptEnv;

        void Awake()
        {
            scriptEnv = luaEnv.NewTable();
            LuaTable meta = luaEnv.NewTable();
            meta.Set("__index", luaEnv.Global);
            scriptEnv.SetMetaTable(meta);
            meta.Dispose();
            scriptEnv.Set("self", this);
            foreach (var injection in Injections)
            {
                scriptEnv.Set(injection.name, injection.value);
            }
            //执行Lua
            luaEnv.DoString(LuaScript.text, "LuaBehaviour", scriptEnv);
            //Inject unity action  
            Action luaAwake = scriptEnv.Get<Action>("awake");
            scriptEnv.Get("Start", out luaStart);
            scriptEnv.Get("Update", out luaUpdate);
            scriptEnv.Get("OnDestroy", out luaOnDestroy);
            scriptEnv.Get("OnEnabled", out luaOnEnable);
            scriptEnv.Get("OnDisable", out luaOnDisAble);
            scriptEnv.Get("FixedUpdate", out luaFixUpdate);
            scriptEnv.Get("LateUpdate", out luaLateUpdate);
            if (luaAwake != null)
            {
                luaAwake();
            }
        }

        void Start()
        {
            if (luaStart != null)
            {
                luaStart();
            }
        }

        void Update()
        {

            if (luaUpdate != null)
            {
                luaUpdate();
            }
            if (Time.time - LuaBehaviour.lastGCTime > GCInterval)
            {
                luaEnv.Tick();
                LuaBehaviour.lastGCTime = Time.time;
            }
        }

        private void LateUpdate()
        {
            if (luaLateUpdate != null)
            {
                luaLateUpdate();
            }
        }

        void OnDestroy()
        {
            if (luaOnDestroy != null)
            {
                luaOnDestroy();
            }
            luaOnDestroy = null;
            luaUpdate = null;
            luaStart = null;
            scriptEnv.Dispose();
            Injections = null;
        }

        private void OnEnable()
        {
            if (luaOnEnable != null)
                luaOnEnable.Invoke();
        }

        private void OnDisable()
        {
            if (luaOnDisAble != null)
                luaOnDisAble.Invoke();
        }

        private void FixedUpdate()
        {
            if (luaFixUpdate != null)
                luaFixUpdate.Invoke();
        }
    }
}
