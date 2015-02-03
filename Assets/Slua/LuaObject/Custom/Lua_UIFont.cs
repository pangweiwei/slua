using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIFont : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIFont o;
		o=new UIFont();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MarkAsChanged(IntPtr l) {
		try{
			UIFont self=(UIFont)checkSelf(l);
			self.MarkAsChanged();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateUVRect(IntPtr l) {
		try{
			UIFont self=(UIFont)checkSelf(l);
			self.UpdateUVRect();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MatchSymbol(IntPtr l) {
		try{
			UIFont self=(UIFont)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			BMSymbol ret=self.MatchSymbol(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddSymbol(IntPtr l) {
		try{
			UIFont self=(UIFont)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.AddSymbol(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveSymbol(IntPtr l) {
		try{
			UIFont self=(UIFont)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.RemoveSymbol(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RenameSymbol(IntPtr l) {
		try{
			UIFont self=(UIFont)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.RenameSymbol(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UsesSprite(IntPtr l) {
		try{
			UIFont self=(UIFont)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.UsesSprite(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CheckIfRelated_s(IntPtr l) {
		try{
			UIFont a1;
			checkType(l,1,out a1);
			UIFont a2;
			checkType(l,2,out a2);
			System.Boolean ret=UIFont.CheckIfRelated(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bmFont(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.bmFont);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bmFont(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		BMFont v;
		checkType(l,2,out v);
		o.bmFont=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texWidth(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.texWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texHeight(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.texHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasSymbols(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.hasSymbols);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_symbols(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.symbols);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_atlas(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.atlas);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_atlas(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		UIAtlas v;
		checkType(l,2,out v);
		o.atlas=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.material=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_premultipliedAlphaShader(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.premultipliedAlphaShader);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_packedFontShader(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.packedFontShader);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texture(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.texture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvRect(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.uvRect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvRect(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		UnityEngine.Rect v;
		checkType(l,2,out v);
		o.uvRect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spriteName(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.spriteName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spriteName(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.spriteName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isValid(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.isValid);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultSize(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.defaultSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultSize(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.defaultSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sprite(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.sprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_replacement(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.replacement);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_replacement(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		UIFont v;
		checkType(l,2,out v);
		o.replacement=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDynamic(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.isDynamic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dynamicFont(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushValue(l,o.dynamicFont);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dynamicFont(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		UnityEngine.Font v;
		checkType(l,2,out v);
		o.dynamicFont=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dynamicFontStyle(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		pushEnum(l,(int)o.dynamicFontStyle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dynamicFontStyle(IntPtr l) {
		UIFont o = (UIFont)checkSelf(l);
		UnityEngine.FontStyle v;
		checkEnum(l,2,out v);
		o.dynamicFontStyle=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIFont");
		addMember(l,MarkAsChanged);
		addMember(l,UpdateUVRect);
		addMember(l,MatchSymbol);
		addMember(l,AddSymbol);
		addMember(l,RemoveSymbol);
		addMember(l,RenameSymbol);
		addMember(l,UsesSprite);
		addMember(l,CheckIfRelated_s);
		addMember(l,"bmFont",get_bmFont,set_bmFont,true);
		addMember(l,"texWidth",get_texWidth,null,true);
		addMember(l,"texHeight",get_texHeight,null,true);
		addMember(l,"hasSymbols",get_hasSymbols,null,true);
		addMember(l,"symbols",get_symbols,null,true);
		addMember(l,"atlas",get_atlas,set_atlas,true);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"premultipliedAlphaShader",get_premultipliedAlphaShader,null,true);
		addMember(l,"packedFontShader",get_packedFontShader,null,true);
		addMember(l,"texture",get_texture,null,true);
		addMember(l,"uvRect",get_uvRect,set_uvRect,true);
		addMember(l,"spriteName",get_spriteName,set_spriteName,true);
		addMember(l,"isValid",get_isValid,null,true);
		addMember(l,"defaultSize",get_defaultSize,set_defaultSize,true);
		addMember(l,"sprite",get_sprite,null,true);
		addMember(l,"replacement",get_replacement,set_replacement,true);
		addMember(l,"isDynamic",get_isDynamic,null,true);
		addMember(l,"dynamicFont",get_dynamicFont,set_dynamicFont,true);
		addMember(l,"dynamicFontStyle",get_dynamicFontStyle,set_dynamicFontStyle,true);
		createTypeMetatable(l,constructor, typeof(UIFont),typeof(UnityEngine.MonoBehaviour));
	}
}
