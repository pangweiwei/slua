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
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
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
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
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
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
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
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
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
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
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
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
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
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.sprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sprite(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		UnityEngine.Sprite v;
		checkType(l,2,out v);
		o.sprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_overrideSprite(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.overrideSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_overrideSprite(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		UnityEngine.Sprite v;
		checkType(l,2,out v);
		o.overrideSprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.type);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		UnityEngine.UI.Image.Type v;
		checkEnum(l,2,out v);
		o.type=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preserveAspect(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.preserveAspect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_preserveAspect(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.preserveAspect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillCenter(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.fillCenter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillCenter(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.fillCenter=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillMethod(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.fillMethod);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillMethod(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		UnityEngine.UI.Image.FillMethod v;
		checkEnum(l,2,out v);
		o.fillMethod=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillAmount(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.fillAmount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillAmount(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.fillAmount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillClockwise(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.fillClockwise);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillClockwise(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.fillClockwise=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillOrigin(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.fillOrigin);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillOrigin(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.fillOrigin=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eventAlphaThreshold(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.eventAlphaThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_eventAlphaThreshold(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.eventAlphaThreshold=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.mainTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasBorder(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.hasBorder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelsPerUnit(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.pixelsPerUnit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.minWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredWidth(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.preferredWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleWidth(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.flexibleWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.minHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredHeight(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.preferredHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleHeight(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.flexibleHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layoutPriority(IntPtr l) {
		UnityEngine.UI.Image o = (UnityEngine.UI.Image)checkSelf(l);
		pushValue(l,o.layoutPriority);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Image");
		addMember(l,OnBeforeSerialize);
		addMember(l,OnAfterDeserialize);
		addMember(l,SetNativeSize);
		addMember(l,CalculateLayoutInputHorizontal);
		addMember(l,CalculateLayoutInputVertical);
		addMember(l,IsRaycastLocationValid);
		addMember(l,"sprite",get_sprite,set_sprite);
		addMember(l,"overrideSprite",get_overrideSprite,set_overrideSprite);
		addMember(l,"type",get_type,set_type);
		addMember(l,"preserveAspect",get_preserveAspect,set_preserveAspect);
		addMember(l,"fillCenter",get_fillCenter,set_fillCenter);
		addMember(l,"fillMethod",get_fillMethod,set_fillMethod);
		addMember(l,"fillAmount",get_fillAmount,set_fillAmount);
		addMember(l,"fillClockwise",get_fillClockwise,set_fillClockwise);
		addMember(l,"fillOrigin",get_fillOrigin,set_fillOrigin);
		addMember(l,"eventAlphaThreshold",get_eventAlphaThreshold,set_eventAlphaThreshold);
		addMember(l,"mainTexture",get_mainTexture,null);
		addMember(l,"hasBorder",get_hasBorder,null);
		addMember(l,"pixelsPerUnit",get_pixelsPerUnit,null);
		addMember(l,"minWidth",get_minWidth,null);
		addMember(l,"preferredWidth",get_preferredWidth,null);
		addMember(l,"flexibleWidth",get_flexibleWidth,null);
		addMember(l,"minHeight",get_minHeight,null);
		addMember(l,"preferredHeight",get_preferredHeight,null);
		addMember(l,"flexibleHeight",get_flexibleHeight,null);
		addMember(l,"layoutPriority",get_layoutPriority,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.Image),typeof(UnityEngine.UI.MaskableGraphic));
	}
}
