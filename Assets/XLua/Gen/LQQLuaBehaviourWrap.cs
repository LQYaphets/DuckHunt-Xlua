#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class LQQLuaBehaviourWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LQQ.LuaBehaviour);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 2, 2);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "LuaScript", _g_get_LuaScript);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Injections", _g_get_Injections);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "LuaScript", _s_set_LuaScript);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Injections", _s_set_Injections);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					LQQ.LuaBehaviour gen_ret = new LQQ.LuaBehaviour();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LQQ.LuaBehaviour constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LuaScript(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.LuaBehaviour gen_to_be_invoked = (LQQ.LuaBehaviour)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.LuaScript);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Injections(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.LuaBehaviour gen_to_be_invoked = (LQQ.LuaBehaviour)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Injections);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LuaScript(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.LuaBehaviour gen_to_be_invoked = (LQQ.LuaBehaviour)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.LuaScript = (UnityEngine.TextAsset)translator.GetObject(L, 2, typeof(UnityEngine.TextAsset));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Injections(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.LuaBehaviour gen_to_be_invoked = (LQQ.LuaBehaviour)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Injections = (Injection[])translator.GetObject(L, 2, typeof(Injection[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
