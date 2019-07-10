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
    public class LQQDuckHuntLuaUMovieWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LQQ.DuckHuntLuaUMovie);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 9, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToPlay", _m_ToPlay);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "showerWidth", _g_get_showerWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "showerHeight", _g_get_showerHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "FrameCount", _g_get_FrameCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MovieName", _g_get_MovieName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LSprites", _g_get_LSprites);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "FSep", _g_get_FSep);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Loop", _g_get_Loop);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "PlayOnEnable", _g_get_PlayOnEnable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OnAnimationPlayEnd", _g_get_OnAnimationPlayEnd);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "MovieName", _s_set_MovieName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "LSprites", _s_set_LSprites);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "FSep", _s_set_FSep);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Loop", _s_set_Loop);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "PlayOnEnable", _s_set_PlayOnEnable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OnAnimationPlayEnd", _s_set_OnAnimationPlayEnd);
            
			
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
					
					LQQ.DuckHuntLuaUMovie gen_ret = new LQQ.DuckHuntLuaUMovie();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LQQ.DuckHuntLuaUMovie constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToPlay(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ToPlay(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showerWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.showerWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showerHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.showerHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_FrameCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.FrameCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MovieName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.MovieName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LSprites(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.LSprites);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_FSep(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.FSep);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Loop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.Loop);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PlayOnEnable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.PlayOnEnable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnAnimationPlayEnd(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.OnAnimationPlayEnd);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MovieName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.MovieName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LSprites(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.LSprites = (System.Collections.Generic.List<UnityEngine.Sprite>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Sprite>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_FSep(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.FSep = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Loop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Loop = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_PlayOnEnable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.PlayOnEnable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnAnimationPlayEnd(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LQQ.DuckHuntLuaUMovie gen_to_be_invoked = (LQQ.DuckHuntLuaUMovie)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.OnAnimationPlayEnd = (UnityEngine.Events.UnityEvent)translator.GetObject(L, 2, typeof(UnityEngine.Events.UnityEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
