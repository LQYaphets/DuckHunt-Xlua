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
    public class DuckHuntLuaResourceRefWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DuckHuntLuaResourceRef);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 7, 7);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "AudioRef", _g_get_AudioRef);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "GameObjectRef", _g_get_GameObjectRef);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "VideoClipRef", _g_get_VideoClipRef);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SpriteRef", _g_get_SpriteRef);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Texture2DRef", _g_get_Texture2DRef);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SkyBoxRef", _g_get_SkyBoxRef);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MaterialRef", _g_get_MaterialRef);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "AudioRef", _s_set_AudioRef);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "GameObjectRef", _s_set_GameObjectRef);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "VideoClipRef", _s_set_VideoClipRef);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SpriteRef", _s_set_SpriteRef);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Texture2DRef", _s_set_Texture2DRef);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SkyBoxRef", _s_set_SkyBoxRef);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MaterialRef", _s_set_MaterialRef);
            
			
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
					
					DuckHuntLuaResourceRef gen_ret = new DuckHuntLuaResourceRef();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to DuckHuntLuaResourceRef constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AudioRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DuckHuntLuaResourceRef gen_to_be_invoked = (DuckHuntLuaResourceRef)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AudioRef);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GameObjectRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DuckHuntLuaResourceRef gen_to_be_invoked = (DuckHuntLuaResourceRef)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.GameObjectRef);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_VideoClipRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DuckHuntLuaResourceRef gen_to_be_invoked = (DuckHuntLuaResourceRef)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.VideoClipRef);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SpriteRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DuckHuntLuaResourceRef gen_to_be_invoked = (DuckHuntLuaResourceRef)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.SpriteRef);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Texture2DRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DuckHuntLuaResourceRef gen_to_be_invoked = (DuckHuntLuaResourceRef)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Texture2DRef);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SkyBoxRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DuckHuntLuaResourceRef gen_to_be_invoked = (DuckHuntLuaResourceRef)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.SkyBoxRef);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MaterialRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DuckHuntLuaResourceRef gen_to_be_invoked = (DuckHuntLuaResourceRef)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.MaterialRef);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AudioRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DuckHuntLuaResourceRef gen_to_be_invoked = (DuckHuntLuaResourceRef)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AudioRef = (UnityEngine.AudioClip[])translator.GetObject(L, 2, typeof(UnityEngine.AudioClip[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_GameObjectRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DuckHuntLuaResourceRef gen_to_be_invoked = (DuckHuntLuaResourceRef)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.GameObjectRef = (UnityEngine.GameObject[])translator.GetObject(L, 2, typeof(UnityEngine.GameObject[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_VideoClipRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DuckHuntLuaResourceRef gen_to_be_invoked = (DuckHuntLuaResourceRef)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.VideoClipRef = (UnityEngine.Video.VideoClip[])translator.GetObject(L, 2, typeof(UnityEngine.Video.VideoClip[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SpriteRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DuckHuntLuaResourceRef gen_to_be_invoked = (DuckHuntLuaResourceRef)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SpriteRef = (UnityEngine.Sprite[])translator.GetObject(L, 2, typeof(UnityEngine.Sprite[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Texture2DRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DuckHuntLuaResourceRef gen_to_be_invoked = (DuckHuntLuaResourceRef)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Texture2DRef = (UnityEngine.Texture2D[])translator.GetObject(L, 2, typeof(UnityEngine.Texture2D[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SkyBoxRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DuckHuntLuaResourceRef gen_to_be_invoked = (DuckHuntLuaResourceRef)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SkyBoxRef = (UnityEngine.Skybox[])translator.GetObject(L, 2, typeof(UnityEngine.Skybox[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MaterialRef(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DuckHuntLuaResourceRef gen_to_be_invoked = (DuckHuntLuaResourceRef)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.MaterialRef = (UnityEngine.Material[])translator.GetObject(L, 2, typeof(UnityEngine.Material[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
