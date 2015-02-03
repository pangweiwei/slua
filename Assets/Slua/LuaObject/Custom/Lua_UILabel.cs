using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UILabel : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UILabel o;
		o=new UILabel();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSides(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3[] ret=self.GetSides(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MarkAsChanged(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			self.MarkAsChanged();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ProcessText(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			self.ProcessText();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MakePixelPerfect(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			self.MakePixelPerfect();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AssumeNaturalSize(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			self.AssumeNaturalSize();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetCharacterIndexAtPosition(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Vector3),typeof(bool))){
				UILabel self=(UILabel)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.Int32 ret=self.GetCharacterIndexAtPosition(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector2),typeof(bool))){
				UILabel self=(UILabel)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.Int32 ret=self.GetCharacterIndexAtPosition(a1,a2);
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
	static public int GetWordAtPosition(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Vector3))){
				UILabel self=(UILabel)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				System.String ret=self.GetWordAtPosition(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector2))){
				UILabel self=(UILabel)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				System.String ret=self.GetWordAtPosition(a1);
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
	static public int GetWordAtCharacterIndex(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.String ret=self.GetWordAtCharacterIndex(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetUrlAtPosition(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Vector3))){
				UILabel self=(UILabel)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				System.String ret=self.GetUrlAtPosition(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector2))){
				UILabel self=(UILabel)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				System.String ret=self.GetUrlAtPosition(a1);
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
	static public int GetUrlAtCharacterIndex(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.String ret=self.GetUrlAtCharacterIndex(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetCharacterIndex(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.KeyCode a2;
			checkEnum(l,3,out a2);
			System.Int32 ret=self.GetCharacterIndex(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PrintOverlay(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UIGeometry a3;
			checkType(l,4,out a3);
			UIGeometry a4;
			checkType(l,5,out a4);
			UnityEngine.Color a5;
			checkType(l,6,out a5);
			UnityEngine.Color a6;
			checkType(l,7,out a6);
			self.PrintOverlay(a1,a2,a3,a4,a5,a6);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnFill(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			BetterList<UnityEngine.Vector3> a1;
			checkType(l,2,out a1);
			BetterList<UnityEngine.Vector2> a2;
			checkType(l,3,out a2);
			BetterList<UnityEngine.Color32> a3;
			checkType(l,4,out a3);
			self.OnFill(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ApplyOffset(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			BetterList<UnityEngine.Vector3> a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Vector2 ret=self.ApplyOffset(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ApplyShadow(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			BetterList<UnityEngine.Vector3> a1;
			checkType(l,2,out a1);
			BetterList<UnityEngine.Vector2> a2;
			checkType(l,3,out a2);
			BetterList<UnityEngine.Color32> a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			System.Single a6;
			checkType(l,7,out a6);
			System.Single a7;
			checkType(l,8,out a7);
			self.ApplyShadow(a1,a2,a3,a4,a5,a6,a7);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateOffsetToFit(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 ret=self.CalculateOffsetToFit(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetCurrentProgress(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			self.SetCurrentProgress();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetCurrentPercent(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			self.SetCurrentPercent();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetCurrentSelection(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			self.SetCurrentSelection();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Wrap(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UILabel self=(UILabel)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				System.Boolean ret=self.Wrap(a1,out a2);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
			}
			else if(argc==4){
				UILabel self=(UILabel)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.String a2;
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Boolean ret=self.Wrap(a1,out a2,a3);
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
	static public int UpdateNGUIText(IntPtr l) {
		try{
			UILabel self=(UILabel)checkSelf(l);
			self.UpdateNGUIText();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keepCrispWhenShrunk(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushEnum(l,(int)o.keepCrispWhenShrunk);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keepCrispWhenShrunk(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		UILabel.Crispness v;
		checkEnum(l,2,out v);
		o.keepCrispWhenShrunk=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isAnchoredHorizontally(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.isAnchoredHorizontally);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isAnchoredVertically(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.isAnchoredVertically);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.material=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bitmapFont(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.bitmapFont);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bitmapFont(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		UIFont v;
		checkType(l,2,out v);
		o.bitmapFont=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_trueTypeFont(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.trueTypeFont);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_trueTypeFont(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		UnityEngine.Font v;
		checkType(l,2,out v);
		o.trueTypeFont=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ambigiousFont(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.ambigiousFont);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ambigiousFont(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		UnityEngine.Object v;
		checkType(l,2,out v);
		o.ambigiousFont=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.text);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.text=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultFontSize(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.defaultFontSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontSize(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.fontSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontSize(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.fontSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontStyle(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushEnum(l,(int)o.fontStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontStyle(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		UnityEngine.FontStyle v;
		checkEnum(l,2,out v);
		o.fontStyle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alignment(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushEnum(l,(int)o.alignment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alignment(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		NGUIText.Alignment v;
		checkEnum(l,2,out v);
		o.alignment=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_applyGradient(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.applyGradient);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_applyGradient(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.applyGradient=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gradientTop(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.gradientTop);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gradientTop(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.gradientTop=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gradientBottom(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.gradientBottom);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gradientBottom(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.gradientBottom=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spacingX(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.spacingX);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spacingX(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.spacingX=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spacingY(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.spacingY);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spacingY(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.spacingY=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useFloatSpacing(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.useFloatSpacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useFloatSpacing(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useFloatSpacing=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_floatSpacingX(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.floatSpacingX);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_floatSpacingX(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.floatSpacingX=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_floatSpacingY(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.floatSpacingY);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_floatSpacingY(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.floatSpacingY=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_effectiveSpacingY(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.effectiveSpacingY);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_effectiveSpacingX(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.effectiveSpacingX);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportEncoding(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.supportEncoding);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_supportEncoding(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.supportEncoding=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_symbolStyle(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushEnum(l,(int)o.symbolStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_symbolStyle(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		NGUIText.SymbolStyle v;
		checkEnum(l,2,out v);
		o.symbolStyle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_overflowMethod(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushEnum(l,(int)o.overflowMethod);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_overflowMethod(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		UILabel.Overflow v;
		checkEnum(l,2,out v);
		o.overflowMethod=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_multiLine(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.multiLine);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_multiLine(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.multiLine=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localCorners(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.localCorners);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldCorners(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.worldCorners);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_drawingDimensions(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.drawingDimensions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxLineCount(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.maxLineCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxLineCount(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.maxLineCount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_effectStyle(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushEnum(l,(int)o.effectStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_effectStyle(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		UILabel.Effect v;
		checkEnum(l,2,out v);
		o.effectStyle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_effectColor(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.effectColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_effectColor(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.effectColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_effectDistance(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.effectDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_effectDistance(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.effectDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_processedText(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.processedText);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_printedSize(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.printedSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localSize(IntPtr l) {
		UILabel o = (UILabel)checkSelf(l);
		pushValue(l,o.localSize);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UILabel");
		addMember(l,GetSides);
		addMember(l,MarkAsChanged);
		addMember(l,ProcessText);
		addMember(l,MakePixelPerfect);
		addMember(l,AssumeNaturalSize);
		addMember(l,GetCharacterIndexAtPosition);
		addMember(l,GetWordAtPosition);
		addMember(l,GetWordAtCharacterIndex);
		addMember(l,GetUrlAtPosition);
		addMember(l,GetUrlAtCharacterIndex);
		addMember(l,GetCharacterIndex);
		addMember(l,PrintOverlay);
		addMember(l,OnFill);
		addMember(l,ApplyOffset);
		addMember(l,ApplyShadow);
		addMember(l,CalculateOffsetToFit);
		addMember(l,SetCurrentProgress);
		addMember(l,SetCurrentPercent);
		addMember(l,SetCurrentSelection);
		addMember(l,Wrap);
		addMember(l,UpdateNGUIText);
		addMember(l,"keepCrispWhenShrunk",get_keepCrispWhenShrunk,set_keepCrispWhenShrunk,true);
		addMember(l,"isAnchoredHorizontally",get_isAnchoredHorizontally,null,true);
		addMember(l,"isAnchoredVertically",get_isAnchoredVertically,null,true);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"bitmapFont",get_bitmapFont,set_bitmapFont,true);
		addMember(l,"trueTypeFont",get_trueTypeFont,set_trueTypeFont,true);
		addMember(l,"ambigiousFont",get_ambigiousFont,set_ambigiousFont,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"defaultFontSize",get_defaultFontSize,null,true);
		addMember(l,"fontSize",get_fontSize,set_fontSize,true);
		addMember(l,"fontStyle",get_fontStyle,set_fontStyle,true);
		addMember(l,"alignment",get_alignment,set_alignment,true);
		addMember(l,"applyGradient",get_applyGradient,set_applyGradient,true);
		addMember(l,"gradientTop",get_gradientTop,set_gradientTop,true);
		addMember(l,"gradientBottom",get_gradientBottom,set_gradientBottom,true);
		addMember(l,"spacingX",get_spacingX,set_spacingX,true);
		addMember(l,"spacingY",get_spacingY,set_spacingY,true);
		addMember(l,"useFloatSpacing",get_useFloatSpacing,set_useFloatSpacing,true);
		addMember(l,"floatSpacingX",get_floatSpacingX,set_floatSpacingX,true);
		addMember(l,"floatSpacingY",get_floatSpacingY,set_floatSpacingY,true);
		addMember(l,"effectiveSpacingY",get_effectiveSpacingY,null,true);
		addMember(l,"effectiveSpacingX",get_effectiveSpacingX,null,true);
		addMember(l,"supportEncoding",get_supportEncoding,set_supportEncoding,true);
		addMember(l,"symbolStyle",get_symbolStyle,set_symbolStyle,true);
		addMember(l,"overflowMethod",get_overflowMethod,set_overflowMethod,true);
		addMember(l,"multiLine",get_multiLine,set_multiLine,true);
		addMember(l,"localCorners",get_localCorners,null,true);
		addMember(l,"worldCorners",get_worldCorners,null,true);
		addMember(l,"drawingDimensions",get_drawingDimensions,null,true);
		addMember(l,"maxLineCount",get_maxLineCount,set_maxLineCount,true);
		addMember(l,"effectStyle",get_effectStyle,set_effectStyle,true);
		addMember(l,"effectColor",get_effectColor,set_effectColor,true);
		addMember(l,"effectDistance",get_effectDistance,set_effectDistance,true);
		addMember(l,"processedText",get_processedText,null,true);
		addMember(l,"printedSize",get_printedSize,null,true);
		addMember(l,"localSize",get_localSize,null,true);
		createTypeMetatable(l,constructor, typeof(UILabel),typeof(UIWidget));
	}
}
