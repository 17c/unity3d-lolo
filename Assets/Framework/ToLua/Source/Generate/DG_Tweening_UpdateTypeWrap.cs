﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DG_Tweening_UpdateTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(DG.Tweening.UpdateType));
		L.RegVar("Normal", get_Normal, null);
		L.RegVar("Late", get_Late, null);
		L.RegVar("Fixed", get_Fixed, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<DG.Tweening.UpdateType>.Check = CheckType;
		StackTraits<DG.Tweening.UpdateType>.Push = Push;
	}

	static void Push(IntPtr L, DG.Tweening.UpdateType arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(DG.Tweening.UpdateType), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Normal(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.UpdateType.Normal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Late(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.UpdateType.Late);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Fixed(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.UpdateType.Fixed);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		DG.Tweening.UpdateType o = (DG.Tweening.UpdateType)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

