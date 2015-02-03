using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_NGUIText : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Update_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				NGUIText.Update();
				return 0;
			}
			else if(argc==2){
				System.Boolean a1;
				checkType(l,1,out a1);
				NGUIText.Update(a1);
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
	static public int Prepare_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			NGUIText.Prepare(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSymbol_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			BMSymbol ret=NGUIText.GetSymbol(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGlyphWidth_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Single ret=NGUIText.GetGlyphWidth(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGlyph_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			NGUIText.GlyphInfo ret=NGUIText.GetGlyph(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ParseAlpha_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Single ret=NGUIText.ParseAlpha(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ParseColor_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Color ret=NGUIText.ParseColor(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ParseColor24_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Color ret=NGUIText.ParseColor24(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ParseColor32_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Color ret=NGUIText.ParseColor32(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EncodeColor_s(IntPtr l) {
		try{
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			System.String ret=NGUIText.EncodeColor(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EncodeAlpha_s(IntPtr l) {
		try{
			System.Single a1;
			checkType(l,1,out a1);
			System.String ret=NGUIText.EncodeAlpha(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EncodeColor24_s(IntPtr l) {
		try{
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			System.String ret=NGUIText.EncodeColor24(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EncodeColor32_s(IntPtr l) {
		try{
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			System.String ret=NGUIText.EncodeColor32(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ParseSymbol_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.String a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Boolean ret=NGUIText.ParseSymbol(a1,ref a2);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
			}
			else if(argc==11){
				System.String a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				BetterList<UnityEngine.Color> a3;
				checkType(l,3,out a3);
				System.Boolean a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Boolean a6;
				checkType(l,6,out a6);
				System.Boolean a7;
				checkType(l,7,out a7);
				System.Boolean a8;
				checkType(l,8,out a8);
				System.Boolean a9;
				checkType(l,9,out a9);
				System.Boolean a10;
				checkType(l,10,out a10);
				System.Boolean ret=NGUIText.ParseSymbol(a1,ref a2,a3,a4,ref a5,ref a6,ref a7,ref a8,ref a9,ref a10);
				pushValue(l,ret);
				pushValue(l,a2);
				pushValue(l,a5);
				pushValue(l,a6);
				pushValue(l,a7);
				pushValue(l,a8);
				pushValue(l,a9);
				pushValue(l,a10);
				return 8;
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
	static public int IsHex_s(IntPtr l) {
		try{
			System.Char a1;
			checkType(l,1,out a1);
			System.Boolean ret=NGUIText.IsHex(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StripSymbols_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.String ret=NGUIText.StripSymbols(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Align_s(IntPtr l) {
		try{
			BetterList<UnityEngine.Vector3> a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			NGUIText.Align(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetExactCharacterIndex_s(IntPtr l) {
		try{
			BetterList<UnityEngine.Vector3> a1;
			checkType(l,1,out a1);
			BetterList<System.Int32> a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,3,out a3);
			System.Int32 ret=NGUIText.GetExactCharacterIndex(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetApproximateCharacterIndex_s(IntPtr l) {
		try{
			BetterList<UnityEngine.Vector3> a1;
			checkType(l,1,out a1);
			BetterList<System.Int32> a2;
			checkType(l,2,out a2);
			UnityEngine.Vector2 a3;
			checkType(l,3,out a3);
			System.Int32 ret=NGUIText.GetApproximateCharacterIndex(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EndLine_s(IntPtr l) {
		try{
			System.Text.StringBuilder a1;
			checkType(l,1,out a1);
			NGUIText.EndLine(ref a1);
			pushValue(l,a1);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculatePrintedSize_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 ret=NGUIText.CalculatePrintedSize(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateOffsetToFit_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 ret=NGUIText.CalculateOffsetToFit(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetEndOfLineThatFits_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.String ret=NGUIText.GetEndOfLineThatFits(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int WrapText_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.String a1;
				checkType(l,1,out a1);
				System.String a2;
				System.Boolean ret=NGUIText.WrapText(a1,out a2);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
			}
			else if(argc==4){
				System.String a1;
				checkType(l,1,out a1);
				System.String a2;
				System.Boolean a3;
				checkType(l,3,out a3);
				System.Boolean ret=NGUIText.WrapText(a1,out a2,a3);
				pushValue(l,ret);
				pushValue(l,a2);
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
	static public int Print_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			BetterList<UnityEngine.Vector3> a2;
			checkType(l,2,out a2);
			BetterList<UnityEngine.Vector2> a3;
			checkType(l,3,out a3);
			BetterList<UnityEngine.Color32> a4;
			checkType(l,4,out a4);
			NGUIText.Print(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PrintApproximateCharacterPositions_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			BetterList<UnityEngine.Vector3> a2;
			checkType(l,2,out a2);
			BetterList<System.Int32> a3;
			checkType(l,3,out a3);
			NGUIText.PrintApproximateCharacterPositions(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PrintExactCharacterPositions_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			BetterList<UnityEngine.Vector3> a2;
			checkType(l,2,out a2);
			BetterList<System.Int32> a3;
			checkType(l,3,out a3);
			NGUIText.PrintExactCharacterPositions(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PrintCaretAndSelection_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			BetterList<UnityEngine.Vector3> a4;
			checkType(l,4,out a4);
			BetterList<UnityEngine.Vector3> a5;
			checkType(l,5,out a5);
			NGUIText.PrintCaretAndSelection(a1,a2,a3,a4,a5);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bitmapFont(IntPtr l) {
		pushValue(l,NGUIText.bitmapFont);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bitmapFont(IntPtr l) {
		UIFont v;
		checkType(l,2,out v);
		NGUIText.bitmapFont=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dynamicFont(IntPtr l) {
		pushValue(l,NGUIText.dynamicFont);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dynamicFont(IntPtr l) {
		UnityEngine.Font v;
		checkType(l,2,out v);
		NGUIText.dynamicFont=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_glyph(IntPtr l) {
		pushValue(l,NGUIText.glyph);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_glyph(IntPtr l) {
		NGUIText.GlyphInfo v;
		checkType(l,2,out v);
		NGUIText.glyph=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontSize(IntPtr l) {
		pushValue(l,NGUIText.fontSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontSize(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		NGUIText.fontSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontScale(IntPtr l) {
		pushValue(l,NGUIText.fontScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontScale(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		NGUIText.fontScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelDensity(IntPtr l) {
		pushValue(l,NGUIText.pixelDensity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelDensity(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		NGUIText.pixelDensity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontStyle(IntPtr l) {
		pushEnum(l,(int)NGUIText.fontStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontStyle(IntPtr l) {
		UnityEngine.FontStyle v;
		checkEnum(l,2,out v);
		NGUIText.fontStyle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alignment(IntPtr l) {
		pushEnum(l,(int)NGUIText.alignment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alignment(IntPtr l) {
		NGUIText.Alignment v;
		checkEnum(l,2,out v);
		NGUIText.alignment=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tint(IntPtr l) {
		pushValue(l,NGUIText.tint);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tint(IntPtr l) {
		UnityEngine.Color v;
		checkType(l,2,out v);
		NGUIText.tint=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rectWidth(IntPtr l) {
		pushValue(l,NGUIText.rectWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rectWidth(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		NGUIText.rectWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rectHeight(IntPtr l) {
		pushValue(l,NGUIText.rectHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rectHeight(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		NGUIText.rectHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_regionWidth(IntPtr l) {
		pushValue(l,NGUIText.regionWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_regionWidth(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		NGUIText.regionWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_regionHeight(IntPtr l) {
		pushValue(l,NGUIText.regionHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_regionHeight(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		NGUIText.regionHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxLines(IntPtr l) {
		pushValue(l,NGUIText.maxLines);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxLines(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		NGUIText.maxLines=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gradient(IntPtr l) {
		pushValue(l,NGUIText.gradient);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gradient(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		NGUIText.gradient=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gradientBottom(IntPtr l) {
		pushValue(l,NGUIText.gradientBottom);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gradientBottom(IntPtr l) {
		UnityEngine.Color v;
		checkType(l,2,out v);
		NGUIText.gradientBottom=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gradientTop(IntPtr l) {
		pushValue(l,NGUIText.gradientTop);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gradientTop(IntPtr l) {
		UnityEngine.Color v;
		checkType(l,2,out v);
		NGUIText.gradientTop=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_encoding(IntPtr l) {
		pushValue(l,NGUIText.encoding);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_encoding(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		NGUIText.encoding=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spacingX(IntPtr l) {
		pushValue(l,NGUIText.spacingX);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spacingX(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		NGUIText.spacingX=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spacingY(IntPtr l) {
		pushValue(l,NGUIText.spacingY);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spacingY(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		NGUIText.spacingY=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_premultiply(IntPtr l) {
		pushValue(l,NGUIText.premultiply);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_premultiply(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		NGUIText.premultiply=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_symbolStyle(IntPtr l) {
		pushEnum(l,(int)NGUIText.symbolStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_symbolStyle(IntPtr l) {
		NGUIText.SymbolStyle v;
		checkEnum(l,2,out v);
		NGUIText.symbolStyle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_finalSize(IntPtr l) {
		pushValue(l,NGUIText.finalSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_finalSize(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		NGUIText.finalSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_finalSpacingX(IntPtr l) {
		pushValue(l,NGUIText.finalSpacingX);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_finalSpacingX(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		NGUIText.finalSpacingX=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_finalLineHeight(IntPtr l) {
		pushValue(l,NGUIText.finalLineHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_finalLineHeight(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		NGUIText.finalLineHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_baseline(IntPtr l) {
		pushValue(l,NGUIText.baseline);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_baseline(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		NGUIText.baseline=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useSymbols(IntPtr l) {
		pushValue(l,NGUIText.useSymbols);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useSymbols(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		NGUIText.useSymbols=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"NGUIText");
		addMember(l,Update_s);
		addMember(l,Prepare_s);
		addMember(l,GetSymbol_s);
		addMember(l,GetGlyphWidth_s);
		addMember(l,GetGlyph_s);
		addMember(l,ParseAlpha_s);
		addMember(l,ParseColor_s);
		addMember(l,ParseColor24_s);
		addMember(l,ParseColor32_s);
		addMember(l,EncodeColor_s);
		addMember(l,EncodeAlpha_s);
		addMember(l,EncodeColor24_s);
		addMember(l,EncodeColor32_s);
		addMember(l,ParseSymbol_s);
		addMember(l,IsHex_s);
		addMember(l,StripSymbols_s);
		addMember(l,Align_s);
		addMember(l,GetExactCharacterIndex_s);
		addMember(l,GetApproximateCharacterIndex_s);
		addMember(l,EndLine_s);
		addMember(l,CalculatePrintedSize_s);
		addMember(l,CalculateOffsetToFit_s);
		addMember(l,GetEndOfLineThatFits_s);
		addMember(l,WrapText_s);
		addMember(l,Print_s);
		addMember(l,PrintApproximateCharacterPositions_s);
		addMember(l,PrintExactCharacterPositions_s);
		addMember(l,PrintCaretAndSelection_s);
		addMember(l,"bitmapFont",get_bitmapFont,set_bitmapFont,false);
		addMember(l,"dynamicFont",get_dynamicFont,set_dynamicFont,false);
		addMember(l,"glyph",get_glyph,set_glyph,false);
		addMember(l,"fontSize",get_fontSize,set_fontSize,false);
		addMember(l,"fontScale",get_fontScale,set_fontScale,false);
		addMember(l,"pixelDensity",get_pixelDensity,set_pixelDensity,false);
		addMember(l,"fontStyle",get_fontStyle,set_fontStyle,false);
		addMember(l,"alignment",get_alignment,set_alignment,false);
		addMember(l,"tint",get_tint,set_tint,false);
		addMember(l,"rectWidth",get_rectWidth,set_rectWidth,false);
		addMember(l,"rectHeight",get_rectHeight,set_rectHeight,false);
		addMember(l,"regionWidth",get_regionWidth,set_regionWidth,false);
		addMember(l,"regionHeight",get_regionHeight,set_regionHeight,false);
		addMember(l,"maxLines",get_maxLines,set_maxLines,false);
		addMember(l,"gradient",get_gradient,set_gradient,false);
		addMember(l,"gradientBottom",get_gradientBottom,set_gradientBottom,false);
		addMember(l,"gradientTop",get_gradientTop,set_gradientTop,false);
		addMember(l,"encoding",get_encoding,set_encoding,false);
		addMember(l,"spacingX",get_spacingX,set_spacingX,false);
		addMember(l,"spacingY",get_spacingY,set_spacingY,false);
		addMember(l,"premultiply",get_premultiply,set_premultiply,false);
		addMember(l,"symbolStyle",get_symbolStyle,set_symbolStyle,false);
		addMember(l,"finalSize",get_finalSize,set_finalSize,false);
		addMember(l,"finalSpacingX",get_finalSpacingX,set_finalSpacingX,false);
		addMember(l,"finalLineHeight",get_finalLineHeight,set_finalLineHeight,false);
		addMember(l,"baseline",get_baseline,set_baseline,false);
		addMember(l,"useSymbols",get_useSymbols,set_useSymbols,false);
		createTypeMetatable(l,constructor, typeof(NGUIText));
	}
}
