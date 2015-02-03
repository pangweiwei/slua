using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_NGUIMath : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Lerp_s(IntPtr l) {
		try{
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single ret=NGUIMath.Lerp(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClampIndex_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 ret=NGUIMath.ClampIndex(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RepeatIndex_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 ret=NGUIMath.RepeatIndex(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int WrapAngle_s(IntPtr l) {
		try{
			System.Single a1;
			checkType(l,1,out a1);
			System.Single ret=NGUIMath.WrapAngle(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Wrap01_s(IntPtr l) {
		try{
			System.Single a1;
			checkType(l,1,out a1);
			System.Single ret=NGUIMath.Wrap01(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HexToDecimal_s(IntPtr l) {
		try{
			System.Char a1;
			checkType(l,1,out a1);
			System.Int32 ret=NGUIMath.HexToDecimal(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DecimalToHexChar_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Char ret=NGUIMath.DecimalToHexChar(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DecimalToHex8_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.String ret=NGUIMath.DecimalToHex8(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DecimalToHex24_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.String ret=NGUIMath.DecimalToHex24(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DecimalToHex32_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.String ret=NGUIMath.DecimalToHex32(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ColorToInt_s(IntPtr l) {
		try{
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			System.Int32 ret=NGUIMath.ColorToInt(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IntToColor_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.Color ret=NGUIMath.IntToColor(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IntToBinary_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.String ret=NGUIMath.IntToBinary(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HexToColor_s(IntPtr l) {
		try{
			System.UInt32 a1;
			checkType(l,1,out a1);
			UnityEngine.Color ret=NGUIMath.HexToColor(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ConvertToTexCoords_s(IntPtr l) {
		try{
			UnityEngine.Rect a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.Rect ret=NGUIMath.ConvertToTexCoords(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ConvertToPixels_s(IntPtr l) {
		try{
			UnityEngine.Rect a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			UnityEngine.Rect ret=NGUIMath.ConvertToPixels(a1,a2,a3,a4);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MakePixelPerfect_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Rect a1;
				checkType(l,1,out a1);
				UnityEngine.Rect ret=NGUIMath.MakePixelPerfect(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Rect a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Rect ret=NGUIMath.MakePixelPerfect(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ConstrainRect_s(IntPtr l) {
		try{
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,3,out a3);
			UnityEngine.Vector2 a4;
			checkType(l,4,out a4);
			UnityEngine.Vector2 ret=NGUIMath.ConstrainRect(a1,a2,a3,a4);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateAbsoluteWidgetBounds_s(IntPtr l) {
		try{
			UnityEngine.Transform a1;
			checkType(l,1,out a1);
			UnityEngine.Bounds ret=NGUIMath.CalculateAbsoluteWidgetBounds(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateRelativeWidgetBounds_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Transform a1;
				checkType(l,1,out a1);
				UnityEngine.Bounds ret=NGUIMath.CalculateRelativeWidgetBounds(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Transform),typeof(bool))){
				UnityEngine.Transform a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				UnityEngine.Bounds ret=NGUIMath.CalculateRelativeWidgetBounds(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Transform),typeof(UnityEngine.Transform))){
				UnityEngine.Transform a1;
				checkType(l,1,out a1);
				UnityEngine.Transform a2;
				checkType(l,2,out a2);
				UnityEngine.Bounds ret=NGUIMath.CalculateRelativeWidgetBounds(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Transform a1;
				checkType(l,1,out a1);
				UnityEngine.Transform a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				System.Boolean a4;
				checkType(l,4,out a4);
				UnityEngine.Bounds ret=NGUIMath.CalculateRelativeWidgetBounds(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SpringDampen_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(float),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 ret=NGUIMath.SpringDampen(ref a1,a2,a3);
				pushValue(l,ret);
				pushValue(l,a1);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector2),typeof(float),typeof(float))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 ret=NGUIMath.SpringDampen(ref a1,a2,a3);
				pushValue(l,ret);
				pushValue(l,a1);
				return 2;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SpringLerp_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single ret=NGUIMath.SpringLerp(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(float),typeof(float))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single ret=NGUIMath.SpringLerp(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(float),typeof(float))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Vector2 ret=NGUIMath.SpringLerp(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(float),typeof(float))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Vector3 ret=NGUIMath.SpringLerp(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Quaternion),typeof(UnityEngine.Quaternion),typeof(float),typeof(float))){
				UnityEngine.Quaternion a1;
				checkType(l,1,out a1);
				UnityEngine.Quaternion a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Quaternion ret=NGUIMath.SpringLerp(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RotateTowards_s(IntPtr l) {
		try{
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single ret=NGUIMath.RotateTowards(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DistanceToRectangle_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Vector2[] a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single ret=NGUIMath.DistanceToRectangle(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector3[] a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Camera a3;
				checkType(l,3,out a3);
				System.Single ret=NGUIMath.DistanceToRectangle(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPivotOffset_s(IntPtr l) {
		try{
			UIWidget.Pivot a1;
			checkEnum(l,1,out a1);
			UnityEngine.Vector2 ret=NGUIMath.GetPivotOffset(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPivot_s(IntPtr l) {
		try{
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UIWidget.Pivot ret=NGUIMath.GetPivot(a1);
			pushEnum(l,(int)ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MoveWidget_s(IntPtr l) {
		try{
			UIRect a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			NGUIMath.MoveWidget(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MoveRect_s(IntPtr l) {
		try{
			UIRect a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			NGUIMath.MoveRect(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResizeWidget_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				UIWidget a1;
				checkType(l,1,out a1);
				UIWidget.Pivot a2;
				checkEnum(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				NGUIMath.ResizeWidget(a1,a2,a3,a4,a5,a6);
				return 0;
			}
			else if(argc==8){
				UIWidget a1;
				checkType(l,1,out a1);
				UIWidget.Pivot a2;
				checkEnum(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				System.Int32 a8;
				checkType(l,8,out a8);
				NGUIMath.ResizeWidget(a1,a2,a3,a4,a5,a6,a7,a8);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AdjustWidget_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UIWidget a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				NGUIMath.AdjustWidget(a1,a2,a3,a4,a5);
				return 0;
			}
			else if(argc==7){
				UIWidget a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				NGUIMath.AdjustWidget(a1,a2,a3,a4,a5,a6,a7);
				return 0;
			}
			else if(argc==9){
				UIWidget a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				System.Int32 a8;
				checkType(l,8,out a8);
				System.Int32 a9;
				checkType(l,9,out a9);
				NGUIMath.AdjustWidget(a1,a2,a3,a4,a5,a6,a7,a8,a9);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AdjustByDPI_s(IntPtr l) {
		try{
			System.Single a1;
			checkType(l,1,out a1);
			System.Int32 ret=NGUIMath.AdjustByDPI(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScreenToPixels_s(IntPtr l) {
		try{
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Transform a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 ret=NGUIMath.ScreenToPixels(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScreenToParentPixels_s(IntPtr l) {
		try{
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Transform a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 ret=NGUIMath.ScreenToParentPixels(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int WorldToLocalPoint_s(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Camera a2;
			checkType(l,2,out a2);
			UnityEngine.Camera a3;
			checkType(l,3,out a3);
			UnityEngine.Transform a4;
			checkType(l,4,out a4);
			UnityEngine.Vector3 ret=NGUIMath.WorldToLocalPoint(a1,a2,a3,a4);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OverlayPosition_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Transform a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Camera a3;
				checkType(l,3,out a3);
				UnityEngine.Camera a4;
				checkType(l,4,out a4);
				NGUIMath.OverlayPosition(a1,a2,a3,a4);
				return 0;
			}
			else if(argc==3){
				UnityEngine.Transform a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Camera a3;
				checkType(l,3,out a3);
				NGUIMath.OverlayPosition(a1,a2,a3);
				return 0;
			}
			else if(argc==2){
				UnityEngine.Transform a1;
				checkType(l,1,out a1);
				UnityEngine.Transform a2;
				checkType(l,2,out a2);
				NGUIMath.OverlayPosition(a1,a2);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"NGUIMath");
		addMember(l,Lerp_s);
		addMember(l,ClampIndex_s);
		addMember(l,RepeatIndex_s);
		addMember(l,WrapAngle_s);
		addMember(l,Wrap01_s);
		addMember(l,HexToDecimal_s);
		addMember(l,DecimalToHexChar_s);
		addMember(l,DecimalToHex8_s);
		addMember(l,DecimalToHex24_s);
		addMember(l,DecimalToHex32_s);
		addMember(l,ColorToInt_s);
		addMember(l,IntToColor_s);
		addMember(l,IntToBinary_s);
		addMember(l,HexToColor_s);
		addMember(l,ConvertToTexCoords_s);
		addMember(l,ConvertToPixels_s);
		addMember(l,MakePixelPerfect_s);
		addMember(l,ConstrainRect_s);
		addMember(l,CalculateAbsoluteWidgetBounds_s);
		addMember(l,CalculateRelativeWidgetBounds_s);
		addMember(l,SpringDampen_s);
		addMember(l,SpringLerp_s);
		addMember(l,RotateTowards_s);
		addMember(l,DistanceToRectangle_s);
		addMember(l,GetPivotOffset_s);
		addMember(l,GetPivot_s);
		addMember(l,MoveWidget_s);
		addMember(l,MoveRect_s);
		addMember(l,ResizeWidget_s);
		addMember(l,AdjustWidget_s);
		addMember(l,AdjustByDPI_s);
		addMember(l,ScreenToPixels_s);
		addMember(l,ScreenToParentPixels_s);
		addMember(l,WorldToLocalPoint_s);
		addMember(l,OverlayPosition_s);
		createTypeMetatable(l,constructor, typeof(NGUIMath));
	}
}
