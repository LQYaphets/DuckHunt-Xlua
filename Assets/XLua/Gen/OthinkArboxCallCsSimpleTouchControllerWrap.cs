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
    public class OthinkArboxCallCsSimpleTouchControllerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Othink.ArboxCallCs.SimpleTouchController);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BeginDrag", _m_BeginDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndDrag", _m_EndDrag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnValueChanged", _m_OnValueChanged);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TouchEvent", _e_TouchEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TouchStateEvent", _e_TouchStateEvent);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "GetTouchPosition", _g_get_GetTouchPosition);
            
			
			
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
					
					Othink.ArboxCallCs.SimpleTouchController gen_ret = new Othink.ArboxCallCs.SimpleTouchController();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Othink.ArboxCallCs.SimpleTouchController constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BeginDrag(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Othink.ArboxCallCs.SimpleTouchController gen_to_be_invoked = (Othink.ArboxCallCs.SimpleTouchController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.BeginDrag(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndDrag(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Othink.ArboxCallCs.SimpleTouchController gen_to_be_invoked = (Othink.ArboxCallCs.SimpleTouchController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.EndDrag(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnValueChanged(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Othink.ArboxCallCs.SimpleTouchController gen_to_be_invoked = (Othink.ArboxCallCs.SimpleTouchController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _value;translator.Get(L, 2, out _value);
                    
                    gen_to_be_invoked.OnValueChanged( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GetTouchPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Othink.ArboxCallCs.SimpleTouchController gen_to_be_invoked = (Othink.ArboxCallCs.SimpleTouchController)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.GetTouchPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_TouchEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Othink.ArboxCallCs.SimpleTouchController gen_to_be_invoked = (Othink.ArboxCallCs.SimpleTouchController)translator.FastGetCSObj(L, 1);
                Othink.ArboxCallCs.SimpleTouchController.TouchDelegate gen_delegate = translator.GetDelegate<Othink.ArboxCallCs.SimpleTouchController.TouchDelegate>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Othink.ArboxCallCs.SimpleTouchController.TouchDelegate!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.TouchEvent += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.TouchEvent -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Othink.ArboxCallCs.SimpleTouchController.TouchEvent!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_TouchStateEvent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Othink.ArboxCallCs.SimpleTouchController gen_to_be_invoked = (Othink.ArboxCallCs.SimpleTouchController)translator.FastGetCSObj(L, 1);
                Othink.ArboxCallCs.SimpleTouchController.TouchStateDelegate gen_delegate = translator.GetDelegate<Othink.ArboxCallCs.SimpleTouchController.TouchStateDelegate>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Othink.ArboxCallCs.SimpleTouchController.TouchStateDelegate!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.TouchStateEvent += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.TouchStateEvent -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Othink.ArboxCallCs.SimpleTouchController.TouchStateEvent!");
            return 0;
        }
        
		
		
    }
}
