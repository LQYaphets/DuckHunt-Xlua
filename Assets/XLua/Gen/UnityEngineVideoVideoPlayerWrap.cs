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
    public class UnityEngineVideoVideoPlayerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Video.VideoPlayer);
			Utils.BeginObjectRegister(type, L, translator, 0, 24, 43, 24);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Prepare", _m_Prepare);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Play", _m_Play);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Pause", _m_Pause);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Stop", _m_Stop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StepForward", _m_StepForward);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAudioLanguageCode", _m_GetAudioLanguageCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAudioChannelCount", _m_GetAudioChannelCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAudioSampleRate", _m_GetAudioSampleRate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnableAudioTrack", _m_EnableAudioTrack);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsAudioTrackEnabled", _m_IsAudioTrackEnabled);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDirectAudioVolume", _m_GetDirectAudioVolume);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDirectAudioVolume", _m_SetDirectAudioVolume);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDirectAudioMute", _m_GetDirectAudioMute);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDirectAudioMute", _m_SetDirectAudioMute);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTargetAudioSource", _m_GetTargetAudioSource);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTargetAudioSource", _m_SetTargetAudioSource);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "prepareCompleted", _e_prepareCompleted);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "loopPointReached", _e_loopPointReached);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "started", _e_started);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "frameDropped", _e_frameDropped);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "errorReceived", _e_errorReceived);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "seekCompleted", _e_seekCompleted);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "clockResyncOccurred", _e_clockResyncOccurred);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "frameReady", _e_frameReady);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "source", _g_get_source);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "url", _g_get_url);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clip", _g_get_clip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderMode", _g_get_renderMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetCamera", _g_get_targetCamera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetTexture", _g_get_targetTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetMaterialRenderer", _g_get_targetMaterialRenderer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetMaterialProperty", _g_get_targetMaterialProperty);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "aspectRatio", _g_get_aspectRatio);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetCameraAlpha", _g_get_targetCameraAlpha);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetCamera3DLayout", _g_get_targetCamera3DLayout);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "texture", _g_get_texture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPrepared", _g_get_isPrepared);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "waitForFirstFrame", _g_get_waitForFirstFrame);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playOnAwake", _g_get_playOnAwake);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPlaying", _g_get_isPlaying);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPaused", _g_get_isPaused);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canSetTime", _g_get_canSetTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "time", _g_get_time);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "frame", _g_get_frame);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clockTime", _g_get_clockTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canStep", _g_get_canStep);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canSetPlaybackSpeed", _g_get_canSetPlaybackSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playbackSpeed", _g_get_playbackSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isLooping", _g_get_isLooping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canSetTimeSource", _g_get_canSetTimeSource);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "timeSource", _g_get_timeSource);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "timeReference", _g_get_timeReference);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "externalReferenceTime", _g_get_externalReferenceTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canSetSkipOnDrop", _g_get_canSetSkipOnDrop);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "skipOnDrop", _g_get_skipOnDrop);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "frameCount", _g_get_frameCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "frameRate", _g_get_frameRate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "length", _g_get_length);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "width", _g_get_width);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "height", _g_get_height);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelAspectRatioNumerator", _g_get_pixelAspectRatioNumerator);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pixelAspectRatioDenominator", _g_get_pixelAspectRatioDenominator);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "audioTrackCount", _g_get_audioTrackCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "controlledAudioTrackCount", _g_get_controlledAudioTrackCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "audioOutputMode", _g_get_audioOutputMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canSetDirectAudioVolume", _g_get_canSetDirectAudioVolume);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sendFrameReadyEvents", _g_get_sendFrameReadyEvents);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "source", _s_set_source);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "url", _s_set_url);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clip", _s_set_clip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "renderMode", _s_set_renderMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetCamera", _s_set_targetCamera);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetTexture", _s_set_targetTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetMaterialRenderer", _s_set_targetMaterialRenderer);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetMaterialProperty", _s_set_targetMaterialProperty);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "aspectRatio", _s_set_aspectRatio);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetCameraAlpha", _s_set_targetCameraAlpha);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetCamera3DLayout", _s_set_targetCamera3DLayout);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "waitForFirstFrame", _s_set_waitForFirstFrame);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playOnAwake", _s_set_playOnAwake);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "time", _s_set_time);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "frame", _s_set_frame);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playbackSpeed", _s_set_playbackSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isLooping", _s_set_isLooping);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "timeSource", _s_set_timeSource);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "timeReference", _s_set_timeReference);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "externalReferenceTime", _s_set_externalReferenceTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "skipOnDrop", _s_set_skipOnDrop);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "controlledAudioTrackCount", _s_set_controlledAudioTrackCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "audioOutputMode", _s_set_audioOutputMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sendFrameReadyEvents", _s_set_sendFrameReadyEvents);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "controlledAudioTrackMaxCount", _g_get_controlledAudioTrackMaxCount);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Video.VideoPlayer gen_ret = new UnityEngine.Video.VideoPlayer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Video.VideoPlayer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Prepare(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Prepare(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Play(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Play(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Pause(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Pause(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Stop(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Stop(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StepForward(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.StepForward(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAudioLanguageCode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ushort _trackIndex = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                        string gen_ret = gen_to_be_invoked.GetAudioLanguageCode( _trackIndex );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAudioChannelCount(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ushort _trackIndex = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                        ushort gen_ret = gen_to_be_invoked.GetAudioChannelCount( _trackIndex );
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
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ushort _trackIndex = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                        uint gen_ret = gen_to_be_invoked.GetAudioSampleRate( _trackIndex );
                        LuaAPI.xlua_pushuint(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnableAudioTrack(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ushort _trackIndex = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    bool _enabled = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.EnableAudioTrack( _trackIndex, _enabled );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsAudioTrackEnabled(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ushort _trackIndex = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.IsAudioTrackEnabled( _trackIndex );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDirectAudioVolume(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ushort _trackIndex = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                        float gen_ret = gen_to_be_invoked.GetDirectAudioVolume( _trackIndex );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDirectAudioVolume(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ushort _trackIndex = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    float _volume = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.SetDirectAudioVolume( _trackIndex, _volume );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDirectAudioMute(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ushort _trackIndex = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.GetDirectAudioMute( _trackIndex );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDirectAudioMute(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ushort _trackIndex = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    bool _mute = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.SetDirectAudioMute( _trackIndex, _mute );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTargetAudioSource(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ushort _trackIndex = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.AudioSource gen_ret = gen_to_be_invoked.GetTargetAudioSource( _trackIndex );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTargetAudioSource(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ushort _trackIndex = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.AudioSource _source = (UnityEngine.AudioSource)translator.GetObject(L, 3, typeof(UnityEngine.AudioSource));
                    
                    gen_to_be_invoked.SetTargetAudioSource( _trackIndex, _source );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_source(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.source);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_url(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.url);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.clip);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.renderMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetCamera(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.targetCamera);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.targetTexture);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetMaterialRenderer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.targetMaterialRenderer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetMaterialProperty(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.targetMaterialProperty);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_aspectRatio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.aspectRatio);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetCameraAlpha(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.targetCameraAlpha);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetCamera3DLayout(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.targetCamera3DLayout);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_texture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.texture);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isPrepared(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isPrepared);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_waitForFirstFrame(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.waitForFirstFrame);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_playOnAwake(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.playOnAwake);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isPlaying(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isPlaying);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isPaused(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isPaused);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canSetTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canSetTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_time(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.time);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_frame(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushint64(L, gen_to_be_invoked.frame);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clockTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.clockTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canStep(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canStep);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canSetPlaybackSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canSetPlaybackSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_playbackSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.playbackSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isLooping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isLooping);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canSetTimeSource(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canSetTimeSource);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_timeSource(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.timeSource);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_timeReference(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.timeReference);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_externalReferenceTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.externalReferenceTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canSetSkipOnDrop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canSetSkipOnDrop);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_skipOnDrop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.skipOnDrop);
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
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.audioTrackCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_controlledAudioTrackMaxCount(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Video.VideoPlayer.controlledAudioTrackMaxCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_controlledAudioTrackCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.controlledAudioTrackCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_audioOutputMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.audioOutputMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canSetDirectAudioVolume(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canSetDirectAudioVolume);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sendFrameReadyEvents(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.sendFrameReadyEvents);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_source(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Video.VideoSource gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.source = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_url(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.url = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.clip = (UnityEngine.Video.VideoClip)translator.GetObject(L, 2, typeof(UnityEngine.Video.VideoClip));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_renderMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Video.VideoRenderMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.renderMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetCamera(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.targetCamera = (UnityEngine.Camera)translator.GetObject(L, 2, typeof(UnityEngine.Camera));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.targetTexture = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetMaterialRenderer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.targetMaterialRenderer = (UnityEngine.Renderer)translator.GetObject(L, 2, typeof(UnityEngine.Renderer));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetMaterialProperty(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.targetMaterialProperty = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_aspectRatio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Video.VideoAspectRatio gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.aspectRatio = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetCameraAlpha(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.targetCameraAlpha = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetCamera3DLayout(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Video.Video3DLayout gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.targetCamera3DLayout = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_waitForFirstFrame(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.waitForFirstFrame = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_playOnAwake(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.playOnAwake = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_time(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.time = LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_frame(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.frame = LuaAPI.lua_toint64(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_playbackSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.playbackSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isLooping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isLooping = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_timeSource(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Video.VideoTimeSource gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.timeSource = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_timeReference(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Video.VideoTimeReference gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.timeReference = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_externalReferenceTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.externalReferenceTime = LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_skipOnDrop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.skipOnDrop = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_controlledAudioTrackCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.controlledAudioTrackCount = (ushort)LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_audioOutputMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Video.VideoAudioOutputMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.audioOutputMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sendFrameReadyEvents(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sendFrameReadyEvents = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_prepareCompleted(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Video.VideoPlayer.EventHandler gen_delegate = translator.GetDelegate<UnityEngine.Video.VideoPlayer.EventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need UnityEngine.Video.VideoPlayer.EventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.prepareCompleted += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.prepareCompleted -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Video.VideoPlayer.prepareCompleted!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_loopPointReached(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Video.VideoPlayer.EventHandler gen_delegate = translator.GetDelegate<UnityEngine.Video.VideoPlayer.EventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need UnityEngine.Video.VideoPlayer.EventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.loopPointReached += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.loopPointReached -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Video.VideoPlayer.loopPointReached!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_started(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Video.VideoPlayer.EventHandler gen_delegate = translator.GetDelegate<UnityEngine.Video.VideoPlayer.EventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need UnityEngine.Video.VideoPlayer.EventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.started += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.started -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Video.VideoPlayer.started!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_frameDropped(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Video.VideoPlayer.EventHandler gen_delegate = translator.GetDelegate<UnityEngine.Video.VideoPlayer.EventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need UnityEngine.Video.VideoPlayer.EventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.frameDropped += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.frameDropped -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Video.VideoPlayer.frameDropped!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_errorReceived(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Video.VideoPlayer.ErrorEventHandler gen_delegate = translator.GetDelegate<UnityEngine.Video.VideoPlayer.ErrorEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need UnityEngine.Video.VideoPlayer.ErrorEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.errorReceived += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.errorReceived -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Video.VideoPlayer.errorReceived!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_seekCompleted(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Video.VideoPlayer.EventHandler gen_delegate = translator.GetDelegate<UnityEngine.Video.VideoPlayer.EventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need UnityEngine.Video.VideoPlayer.EventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.seekCompleted += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.seekCompleted -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Video.VideoPlayer.seekCompleted!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_clockResyncOccurred(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Video.VideoPlayer.TimeEventHandler gen_delegate = translator.GetDelegate<UnityEngine.Video.VideoPlayer.TimeEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need UnityEngine.Video.VideoPlayer.TimeEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.clockResyncOccurred += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.clockResyncOccurred -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Video.VideoPlayer.clockResyncOccurred!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_frameReady(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.Video.VideoPlayer gen_to_be_invoked = (UnityEngine.Video.VideoPlayer)translator.FastGetCSObj(L, 1);
                UnityEngine.Video.VideoPlayer.FrameReadyEventHandler gen_delegate = translator.GetDelegate<UnityEngine.Video.VideoPlayer.FrameReadyEventHandler>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need UnityEngine.Video.VideoPlayer.FrameReadyEventHandler!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.frameReady += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.frameReady -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Video.VideoPlayer.frameReady!");
            return 0;
        }
        
		
		
    }
}
