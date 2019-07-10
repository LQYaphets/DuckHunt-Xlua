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
    public class LQQDuckHuntLuaCallCSWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LQQ.DuckHuntLuaCallCS);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRunningPlatform", _m_GetRunningPlatform);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Raycast", _m_Raycast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetScreenWidthAndHeight", _m_GetScreenWidthAndHeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInputAxis", _m_GetInputAxis);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Quit", _m_Quit);
			
			
			
			
			
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
					
					LQQ.DuckHuntLuaCallCS gen_ret = new LQQ.DuckHuntLuaCallCS();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LQQ.DuckHuntLuaCallCS constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRunningPlatform(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LQQ.DuckHuntLuaCallCS gen_to_be_invoked = (LQQ.DuckHuntLuaCallCS)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        LQQ.RunningPlatform gen_ret = gen_to_be_invoked.GetRunningPlatform(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Raycast(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LQQ.DuckHuntLuaCallCS gen_to_be_invoked = (LQQ.DuckHuntLuaCallCS)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Ray __ray;translator.Get(L, 2, out __ray);
                    float _rayDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.RaycastHit gen_ret = gen_to_be_invoked.Raycast( __ray, _rayDistance );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetScreenWidthAndHeight(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LQQ.DuckHuntLuaCallCS gen_to_be_invoked = (LQQ.DuckHuntLuaCallCS)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        UnityEngine.Vector2 gen_ret = gen_to_be_invoked.GetScreenWidthAndHeight(  );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInputAxis(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LQQ.DuckHuntLuaCallCS gen_to_be_invoked = (LQQ.DuckHuntLuaCallCS)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _axisName = LuaAPI.lua_tostring(L, 2);
                    
                        float gen_ret = gen_to_be_invoked.GetInputAxis( _axisName );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Quit(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LQQ.DuckHuntLuaCallCS gen_to_be_invoked = (LQQ.DuckHuntLuaCallCS)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Quit(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
