using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Image : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnBeforeSerialize(IntPtr l) {
		try{
			UnityEngine.UI.Image self=checkSelf<UnityEngine.UI.Image>(l);
			self.OnBeforeSerialize();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnAfterDeserialize(IntPtr l) {
		try{
			UnityEngine.UI.Image self=checkSelf<UnityEngine.UI.Image>(l);
			self.OnAfterDeserialize();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetNativeSize(IntPtr l) {
		try{
			UnityEngine.UI.Image self=checkSelf<UnityEngine.UI.Image>(l);
			self.SetNativeSize();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputHorizontal(IntPtr l) {
		try{
			UnityEngine.UI.Image self=checkSelf<UnityEngine.UI.Image>(l);
			self.CalculateLayoutInputHorizontal();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputVertical(IntPtr l) {
		try{
			UnityEngine.UI.Image self=checkSelf<UnityEngine.UI.Image>(l);
			self.CalculateLayoutInputVertical();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsRaycastLocationValid(IntPtr l) {
		try{
			UnityEngine.UI.Image self=checkSelf<UnityEngine.UI.Image>(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			UnityEngine.Camera a2;
			checkType(l,3,out a2);
			System.Boolean ret=self.IsRaycastLocationValid(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sprite(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.sprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sprite(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		UnityEngine.Sprite v;
		checkType(l,2,out v);
		o.sprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_overrideSprite(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.overrideSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_overrideSprite(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		UnityEngine.Sprite v;
		checkType(l,2,out v);
		o.overrideSprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.type);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		UnityEngine.UI.Image.Type v;
		checkEnum(l,2,out v);
		o.type=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preserveAspect(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.preserveAspect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_preserveAspect(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.preserveAspect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillCenter(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.fillCenter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillCenter(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.fillCenter=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillMethod(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.fillMethod);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillMethod(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		UnityEngine.UI.Image.FillMethod v;
		checkEnum(l,2,out v);
		o.fillMethod=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillAmount(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.fillAmount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillAmount(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		System.Single v;
		checkType(l,2,out v);
		o.fillAmount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillClockwise(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.fillClockwise);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillClockwise(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.fillClockwise=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillOrigin(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.fillOrigin);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillOrigin(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.fillOrigin=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eventAlphaThreshold(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.eventAlphaThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_eventAlphaThreshold(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		System.Single v;
		checkType(l,2,out v);
		o.eventAlphaThreshold=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.mainTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasBorder(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.hasBorder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelsPerUnit(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.pixelsPerUnit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.minWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredWidth(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.preferredWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleWidth(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.flexibleWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.minHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredHeight(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.preferredHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleHeight(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.flexibleHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layoutPriority(IntPtr l) {
		UnityEngine.UI.Image o = checkSelf<UnityEngine.UI.Image>(l);
		pushValue(l,o.layoutPriority);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Image");
		addMember(l,OnBeforeSerialize, "OnBeforeSerialize");
		addMember(l,OnAfterDeserialize, "OnAfterDeserialize");
		addMember(l,SetNativeSize, "SetNativeSize");
		addMember(l,CalculateLayoutInputHorizontal, "CalculateLayoutInputHorizontal");
		addMember(l,CalculateLayoutInputVertical, "CalculateLayoutInputVertical");
		addMember(l,IsRaycastLocationValid, "IsRaycastLocationValid");
		addMember(l,get_sprite, "get_sprite");
		addMember(l,set_sprite, "set_sprite");
		addMember(l,get_overrideSprite, "get_overrideSprite");
		addMember(l,set_overrideSprite, "set_overrideSprite");
		addMember(l,get_type, "get_type");
		addMember(l,set_type, "set_type");
		addMember(l,get_preserveAspect, "get_preserveAspect");
		addMember(l,set_preserveAspect, "set_preserveAspect");
		addMember(l,get_fillCenter, "get_fillCenter");
		addMember(l,set_fillCenter, "set_fillCenter");
		addMember(l,get_fillMethod, "get_fillMethod");
		addMember(l,set_fillMethod, "set_fillMethod");
		addMember(l,get_fillAmount, "get_fillAmount");
		addMember(l,set_fillAmount, "set_fillAmount");
		addMember(l,get_fillClockwise, "get_fillClockwise");
		addMember(l,set_fillClockwise, "set_fillClockwise");
		addMember(l,get_fillOrigin, "get_fillOrigin");
		addMember(l,set_fillOrigin, "set_fillOrigin");
		addMember(l,get_eventAlphaThreshold, "get_eventAlphaThreshold");
		addMember(l,set_eventAlphaThreshold, "set_eventAlphaThreshold");
		addMember(l,get_mainTexture, "get_mainTexture");
		addMember(l,get_hasBorder, "get_hasBorder");
		addMember(l,get_pixelsPerUnit, "get_pixelsPerUnit");
		addMember(l,get_minWidth, "get_minWidth");
		addMember(l,get_preferredWidth, "get_preferredWidth");
		addMember(l,get_flexibleWidth, "get_flexibleWidth");
		addMember(l,get_minHeight, "get_minHeight");
		addMember(l,get_preferredHeight, "get_preferredHeight");
		addMember(l,get_flexibleHeight, "get_flexibleHeight");
		addMember(l,get_layoutPriority, "get_layoutPriority");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.Image),typeof(UnityEngine.UI.MaskableGraphic));
		LuaDLL.lua_pop(l, 1);
	}
}
