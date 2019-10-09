﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ShibaInu_PickerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ShibaInu.Picker), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("ScrollByIndex", ScrollByIndex);
		L.RegFunction("ScrollToSelectedItem", ScrollToSelectedItem);
		L.RegFunction("Clean", Clean);
		L.RegFunction("SerializedPropertyChanged", SerializedPropertyChanged);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("luaTarget", null, set_luaTarget);
		L.RegVar("hitArea", get_hitArea, set_hitArea);
		L.RegVar("itemPrefab", get_itemPrefab, set_itemPrefab);
		L.RegVar("itemOffsetCount", get_itemOffsetCount, set_itemOffsetCount);
		L.RegVar("itemAlphaOffset", get_itemAlphaOffset, set_itemAlphaOffset);
		L.RegVar("itemScaleOffset", get_itemScaleOffset, set_itemScaleOffset);
		L.RegVar("isVertical", get_isVertical, set_isVertical);
		L.RegVar("isBounces", get_isBounces, set_isBounces);
		L.RegVar("scrollRatio", get_scrollRatio, set_scrollRatio);
		L.RegVar("content", get_content, null);
		L.RegVar("itemCount", get_itemCount, set_itemCount);
		L.RegVar("index", get_index, set_index);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScrollByIndex(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				ShibaInu.Picker obj = (ShibaInu.Picker)ToLua.CheckObject<ShibaInu.Picker>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				obj.ScrollByIndex(arg0);
				return 0;
			}
			else if (count == 3)
			{
				ShibaInu.Picker obj = (ShibaInu.Picker)ToLua.CheckObject<ShibaInu.Picker>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				obj.ScrollByIndex(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ShibaInu.Picker.ScrollByIndex");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScrollToSelectedItem(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				ShibaInu.Picker obj = (ShibaInu.Picker)ToLua.CheckObject<ShibaInu.Picker>(L, 1);
				obj.ScrollToSelectedItem();
				return 0;
			}
			else if (count == 2)
			{
				ShibaInu.Picker obj = (ShibaInu.Picker)ToLua.CheckObject<ShibaInu.Picker>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				obj.ScrollToSelectedItem(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ShibaInu.Picker.ScrollToSelectedItem");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clean(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)ToLua.CheckObject<ShibaInu.Picker>(L, 1);
			obj.Clean();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SerializedPropertyChanged(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ShibaInu.Picker obj = (ShibaInu.Picker)ToLua.CheckObject<ShibaInu.Picker>(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.SerializedPropertyChanged(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hitArea(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			UnityEngine.GameObject ret = obj.hitArea;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index hitArea on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_itemPrefab(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			UnityEngine.GameObject ret = obj.itemPrefab;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemPrefab on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_itemOffsetCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			uint ret = obj.itemOffsetCount;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemOffsetCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_itemAlphaOffset(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			float ret = obj.itemAlphaOffset;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemAlphaOffset on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_itemScaleOffset(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			float ret = obj.itemScaleOffset;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemScaleOffset on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isVertical(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			bool ret = obj.isVertical;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isVertical on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isBounces(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			bool ret = obj.isBounces;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isBounces on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scrollRatio(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			float ret = obj.scrollRatio;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scrollRatio on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_content(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			UnityEngine.RectTransform ret = obj.content;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index content on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_itemCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			uint ret = obj.itemCount;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_index(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			int ret = obj.index;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index index on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_luaTarget(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			LuaTable arg0 = ToLua.CheckLuaTable(L, 2);
			obj.luaTarget = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index luaTarget on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hitArea(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			obj.hitArea = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index hitArea on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_itemPrefab(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			obj.itemPrefab = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemPrefab on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_itemOffsetCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			obj.itemOffsetCount = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemOffsetCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_itemAlphaOffset(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.itemAlphaOffset = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemAlphaOffset on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_itemScaleOffset(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.itemScaleOffset = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemScaleOffset on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isVertical(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.isVertical = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isVertical on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isBounces(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.isBounces = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isBounces on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_scrollRatio(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.scrollRatio = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scrollRatio on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_itemCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			obj.itemCount = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_index(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.Picker obj = (ShibaInu.Picker)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.index = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index index on a nil value");
		}
	}
}
