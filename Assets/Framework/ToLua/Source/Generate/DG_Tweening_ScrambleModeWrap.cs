﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DG_Tweening_ScrambleModeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(DG.Tweening.ScrambleMode));
		L.RegVar("None", get_None, null);
		L.RegVar("All", get_All, null);
		L.RegVar("Uppercase", get_Uppercase, null);
		L.RegVar("Lowercase", get_Lowercase, null);
		L.RegVar("Numerals", get_Numerals, null);
		L.RegVar("Custom", get_Custom, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<DG.Tweening.ScrambleMode>.Check = CheckType;
		StackTraits<DG.Tweening.ScrambleMode>.Push = Push;
	}

	static void Push(IntPtr L, DG.Tweening.ScrambleMode arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(DG.Tweening.ScrambleMode), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_None(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.ScrambleMode.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_All(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.ScrambleMode.All);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Uppercase(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.ScrambleMode.Uppercase);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Lowercase(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.ScrambleMode.Lowercase);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Numerals(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.ScrambleMode.Numerals);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Custom(IntPtr L)
	{
		ToLua.Push(L, DG.Tweening.ScrambleMode.Custom);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		DG.Tweening.ScrambleMode o = (DG.Tweening.ScrambleMode)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

