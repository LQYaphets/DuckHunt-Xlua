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
    public class LQQDuckHuntLuaCollisionWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LQQ.DuckHuntLuaCollision);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 0, 0);
			
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EventEnter", _e_EventEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EventStay", _e_EventStay);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EventExit", _e_EventExit);
			
			
			
			
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
					
					LQQ.DuckHuntLuaCollision gen_ret = new LQQ.DuckHuntLuaCollision();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LQQ.DuckHuntLuaCollision constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_EventEnter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			LQQ.DuckHuntLuaCollision gen_to_be_invoked = (LQQ.DuckHuntLuaCollision)translator.FastGetCSObj(L, 1);
                LQQ.LuaCollisionDelegate gen_delegate = translator.GetDelegate<LQQ.LuaCollisionDelegate>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need LQQ.LuaCollisionDelegate!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.EventEnter += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.EventEnter -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to LQQ.DuckHuntLuaCollision.EventEnter!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_EventStay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			LQQ.DuckHuntLuaCollision gen_to_be_invoked = (LQQ.DuckHuntLuaCollision)translator.FastGetCSObj(L, 1);
                LQQ.LuaCollisionDelegate gen_delegate = translator.GetDelegate<LQQ.LuaCollisionDelegate>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need LQQ.LuaCollisionDelegate!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.EventStay += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.EventStay -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to LQQ.DuckHuntLuaCollision.EventStay!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_EventExit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			LQQ.DuckHuntLuaCollision gen_to_be_invoked = (LQQ.DuckHuntLuaCollision)translator.FastGetCSObj(L, 1);
                LQQ.LuaCollisionDelegate gen_delegate = translator.GetDelegate<LQQ.LuaCollisionDelegate>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need LQQ.LuaCollisionDelegate!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.EventExit += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.EventExit -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to LQQ.DuckHuntLuaCollision.EventExit!");
            return 0;
        }
        
		
		
    }
}
