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
    public class UnityEngineVideoVideoClipWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Video.VideoClip);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 9, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAudioChannelCount", _m_GetAudioChannelCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAudioSampleRate", _m_GetAudioSampleRate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAudioLanguage", _m_GetAudioLanguage);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "originalPath", _g_get_originalPath);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "frameCount", _g_get_frameCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "frameRate", _g_get_frameRate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "length", _g_get_length);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "width", _g_get_width);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "height", _g_get_height);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelAspectRatioNumerator", _g_get_pixelAspectRatioNumerator);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelAspectRatioDenominator", _g_get_pixelAspectRatioDenominator);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "audioTrackCount", _g_get_audioTrackCount);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.Video.VideoClip does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAudioChannelCount(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoClip gen_to_be_invoked = (UnityEngine.Video.VideoClip)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ushort _audioTrackIdx = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                        ushort gen_ret = gen_to_be_invoked.GetAudioChannelCount( _audioTrackIdx );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAudioSampleRate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoClip gen_to_be_invoked = (UnityEngine.Video.VideoClip)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ushort _audioTrackIdx = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                        uint gen_ret = gen_to_be_invoked.GetAudioSampleRate( _audioTrackIdx );
                        LuaAPI.xlua_pushuint(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAudioLanguage(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoClip gen_to_be_invoked = (UnityEngine.Video.VideoClip)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ushort _audioTrackIdx = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                        string gen_ret = gen_to_be_invoked.GetAudioLanguage( _audioTrackIdx );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_originalPath(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoClip gen_to_be_invoked = (UnityEngine.Video.VideoClip)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.originalPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_frameCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoClip gen_to_be_invoked = (UnityEngine.Video.VideoClip)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushuint64(L, gen_to_be_invoked.frameCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_frameRate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoClip gen_to_be_invoked = (UnityEngine.Video.VideoClip)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.frameRate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_length(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoClip gen_to_be_invoked = (UnityEngine.Video.VideoClip)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.length);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_width(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoClip gen_to_be_invoked = (UnityEngine.Video.VideoClip)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushuint(L, gen_to_be_invoked.width);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_height(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoClip gen_to_be_invoked = (UnityEngine.Video.VideoClip)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushuint(L, gen_to_be_invoked.height);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pixelAspectRatioNumerator(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoClip gen_to_be_invoked = (UnityEngine.Video.VideoClip)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushuint(L, gen_to_be_invoked.pixelAspectRatioNumerator);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pixelAspectRatioDenominator(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoClip gen_to_be_invoked = (UnityEngine.Video.VideoClip)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushuint(L, gen_to_be_invoked.pixelAspectRatioDenominator);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_audioTrackCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoClip gen_to_be_invoked = (UnityEngine.Video.VideoClip)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.audioTrackCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
