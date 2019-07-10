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
    public class SimpleJSONJSONNodeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(SimpleJSON.JSONNode);
			Utils.BeginObjectRegister(type, L, translator, 1, 14, 10, 5);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", __EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Add", _m_Add);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "get_Item", _m_get_Item);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "set_Item", _m_set_Item);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Remove", _m_Remove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Serialize", _m_Serialize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SaveToStream", _m_SaveToStream);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SaveToCompressedStream", _m_SaveToCompressedStream);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SaveToCompressedFile", _m_SaveToCompressedFile);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SaveToCompressedBase64", _m_SaveToCompressedBase64);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SaveToFile", _m_SaveToFile);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SaveToBase64", _m_SaveToBase64);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Value", _g_get_Value);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Count", _g_get_Count);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Childs", _g_get_Childs);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DeepChilds", _g_get_DeepChilds);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsInt", _g_get_AsInt);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsFloat", _g_get_AsFloat);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsDouble", _g_get_AsDouble);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBool", _g_get_AsBool);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsArray", _g_get_AsArray);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsObject", _g_get_AsObject);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Value", _s_set_Value);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AsInt", _s_set_AsInt);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AsFloat", _s_set_AsFloat);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AsDouble", _s_set_AsDouble);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AsBool", _s_set_AsBool);
            
			
			Utils.EndObjectRegister(type, L, translator, __CSIndexer, __NewIndexer,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 9, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Parse", _m_Parse_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Deserialize", _m_Deserialize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadFromCompressedFile", _m_LoadFromCompressedFile_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadFromCompressedStream", _m_LoadFromCompressedStream_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadFromCompressedBase64", _m_LoadFromCompressedBase64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadFromStream", _m_LoadFromStream_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadFromFile", _m_LoadFromFile_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadFromBase64", _m_LoadFromBase64_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					SimpleJSON.JSONNode gen_ret = new SimpleJSON.JSONNode();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to SimpleJSON.JSONNode constructor!");
            
        }
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __CSIndexer(RealStatePtr L)
        {
			try {
			    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (translator.Assignable<SimpleJSON.JSONNode>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					
					SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
					int index = LuaAPI.xlua_tointeger(L, 2);
					LuaAPI.lua_pushboolean(L, true);
					translator.Push(L, gen_to_be_invoked[index]);
					return 2;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __NewIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
			try {
				
				if (translator.Assignable<SimpleJSON.JSONNode>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && translator.Assignable<SimpleJSON.JSONNode>(L, 3))
				{
					
					SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
					int key = LuaAPI.xlua_tointeger(L, 2);
					gen_to_be_invoked[key] = (SimpleJSON.JSONNode)translator.GetObject(L, 3, typeof(SimpleJSON.JSONNode));
					LuaAPI.lua_pushboolean(L, true);
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			
			LuaAPI.lua_pushboolean(L, false);
            return 1;
        }
		
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __EqMeta(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			
				if (translator.Assignable<SimpleJSON.JSONNode>(L, 1) && translator.Assignable<object>(L, 2))
				{
					SimpleJSON.JSONNode leftside = (SimpleJSON.JSONNode)translator.GetObject(L, 1, typeof(SimpleJSON.JSONNode));
					object rightside = translator.GetObject(L, 2, typeof(object));
					
					LuaAPI.lua_pushboolean(L, leftside == rightside);
					
					return 1;
				}
            
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need SimpleJSON.JSONNode!");
            
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Add(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<SimpleJSON.JSONNode>(L, 2)) 
                {
                    SimpleJSON.JSONNode _aItem = (SimpleJSON.JSONNode)translator.GetObject(L, 2, typeof(SimpleJSON.JSONNode));
                    
                    gen_to_be_invoked.Add( _aItem );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<SimpleJSON.JSONNode>(L, 3)) 
                {
                    string _aKey = LuaAPI.lua_tostring(L, 2);
                    SimpleJSON.JSONNode _aItem = (SimpleJSON.JSONNode)translator.GetObject(L, 3, typeof(SimpleJSON.JSONNode));
                    
                    gen_to_be_invoked.Add( _aKey, _aItem );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to SimpleJSON.JSONNode.Add!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_get_Item(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
					string key = LuaAPI.lua_tostring(L, 2);
					translator.Push(L, gen_to_be_invoked[key]);
					
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_set_Item(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
					string key = LuaAPI.lua_tostring(L, 2);
					gen_to_be_invoked[key] = (SimpleJSON.JSONNode)translator.GetObject(L, 3, typeof(SimpleJSON.JSONNode));
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Remove(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _aIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        SimpleJSON.JSONNode gen_ret = gen_to_be_invoked.Remove( _aIndex );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _aKey = LuaAPI.lua_tostring(L, 2);
                    
                        SimpleJSON.JSONNode gen_ret = gen_to_be_invoked.Remove( _aKey );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<SimpleJSON.JSONNode>(L, 2)) 
                {
                    SimpleJSON.JSONNode _aNode = (SimpleJSON.JSONNode)translator.GetObject(L, 2, typeof(SimpleJSON.JSONNode));
                    
                        SimpleJSON.JSONNode gen_ret = gen_to_be_invoked.Remove( _aNode );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to SimpleJSON.JSONNode.Remove!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        string gen_ret = gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _aPrefix = LuaAPI.lua_tostring(L, 2);
                    
                        string gen_ret = gen_to_be_invoked.ToString( _aPrefix );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to SimpleJSON.JSONNode.ToString!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _obj );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Parse_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _aJSON = LuaAPI.lua_tostring(L, 1);
                    
                        SimpleJSON.JSONNode gen_ret = SimpleJSON.JSONNode.Parse( _aJSON );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Serialize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IO.BinaryWriter _aWriter = (System.IO.BinaryWriter)translator.GetObject(L, 2, typeof(System.IO.BinaryWriter));
                    
                    gen_to_be_invoked.Serialize( _aWriter );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SaveToStream(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IO.Stream _aData = (System.IO.Stream)translator.GetObject(L, 2, typeof(System.IO.Stream));
                    
                    gen_to_be_invoked.SaveToStream( _aData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SaveToCompressedStream(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IO.Stream _aData = (System.IO.Stream)translator.GetObject(L, 2, typeof(System.IO.Stream));
                    
                    gen_to_be_invoked.SaveToCompressedStream( _aData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SaveToCompressedFile(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _aFileName = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.SaveToCompressedFile( _aFileName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SaveToCompressedBase64(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.SaveToCompressedBase64(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SaveToFile(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _aFileName = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.SaveToFile( _aFileName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SaveToBase64(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.SaveToBase64(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Deserialize_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IO.BinaryReader _aReader = (System.IO.BinaryReader)translator.GetObject(L, 1, typeof(System.IO.BinaryReader));
                    
                        SimpleJSON.JSONNode gen_ret = SimpleJSON.JSONNode.Deserialize( _aReader );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadFromCompressedFile_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _aFileName = LuaAPI.lua_tostring(L, 1);
                    
                        SimpleJSON.JSONNode gen_ret = SimpleJSON.JSONNode.LoadFromCompressedFile( _aFileName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadFromCompressedStream_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IO.Stream _aData = (System.IO.Stream)translator.GetObject(L, 1, typeof(System.IO.Stream));
                    
                        SimpleJSON.JSONNode gen_ret = SimpleJSON.JSONNode.LoadFromCompressedStream( _aData );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadFromCompressedBase64_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _aBase64 = LuaAPI.lua_tostring(L, 1);
                    
                        SimpleJSON.JSONNode gen_ret = SimpleJSON.JSONNode.LoadFromCompressedBase64( _aBase64 );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadFromStream_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IO.Stream _aData = (System.IO.Stream)translator.GetObject(L, 1, typeof(System.IO.Stream));
                    
                        SimpleJSON.JSONNode gen_ret = SimpleJSON.JSONNode.LoadFromStream( _aData );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadFromFile_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _aFileName = LuaAPI.lua_tostring(L, 1);
                    
                        SimpleJSON.JSONNode gen_ret = SimpleJSON.JSONNode.LoadFromFile( _aFileName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadFromBase64_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _aBase64 = LuaAPI.lua_tostring(L, 1);
                    
                        SimpleJSON.JSONNode gen_ret = SimpleJSON.JSONNode.LoadFromBase64( _aBase64 );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Value(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Value);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Count(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Count);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Childs(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Childs);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DeepChilds(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.DeepChilds);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsInt(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.AsInt);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsFloat(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.AsFloat);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsDouble(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.AsDouble);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBool(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.AsBool);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsArray(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsArray);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsObject);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Value(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Value = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AsInt(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AsInt = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AsFloat(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AsFloat = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AsDouble(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AsDouble = LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AsBool(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                SimpleJSON.JSONNode gen_to_be_invoked = (SimpleJSON.JSONNode)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AsBool = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
