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
    public class ImageEffect_MoblieBloomWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ImageEffect_MoblieBloom);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 5, 5);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDisable", _m_OnDisable);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "BloomShader", _g_get_BloomShader);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colorMix", _g_get_colorMix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "threshold", _g_get_threshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "intensity", _g_get_intensity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "BlurSize", _g_get_BlurSize);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "BloomShader", _s_set_BloomShader);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "colorMix", _s_set_colorMix);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "threshold", _s_set_threshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "intensity", _s_set_intensity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "BlurSize", _s_set_BlurSize);
            
			
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
					
					ImageEffect_MoblieBloom gen_ret = new ImageEffect_MoblieBloom();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ImageEffect_MoblieBloom constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnDisable(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ImageEffect_MoblieBloom gen_to_be_invoked = (ImageEffect_MoblieBloom)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnDisable(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BloomShader(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImageEffect_MoblieBloom gen_to_be_invoked = (ImageEffect_MoblieBloom)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.BloomShader);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colorMix(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImageEffect_MoblieBloom gen_to_be_invoked = (ImageEffect_MoblieBloom)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.colorMix);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_threshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImageEffect_MoblieBloom gen_to_be_invoked = (ImageEffect_MoblieBloom)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.threshold);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_intensity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImageEffect_MoblieBloom gen_to_be_invoked = (ImageEffect_MoblieBloom)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.intensity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BlurSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImageEffect_MoblieBloom gen_to_be_invoked = (ImageEffect_MoblieBloom)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.BlurSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_BloomShader(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImageEffect_MoblieBloom gen_to_be_invoked = (ImageEffect_MoblieBloom)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.BloomShader = (UnityEngine.Shader)translator.GetObject(L, 2, typeof(UnityEngine.Shader));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colorMix(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImageEffect_MoblieBloom gen_to_be_invoked = (ImageEffect_MoblieBloom)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.colorMix = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_threshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImageEffect_MoblieBloom gen_to_be_invoked = (ImageEffect_MoblieBloom)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.threshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_intensity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImageEffect_MoblieBloom gen_to_be_invoked = (ImageEffect_MoblieBloom)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.intensity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_BlurSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImageEffect_MoblieBloom gen_to_be_invoked = (ImageEffect_MoblieBloom)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.BlurSize = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
