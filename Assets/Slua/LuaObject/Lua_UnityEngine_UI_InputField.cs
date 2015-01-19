using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_InputField : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MoveTextEnd(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.MoveTextEnd(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MoveTextStart(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.MoveTextStart(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScreenToLocal(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 ret=self.ScreenToLocal(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnBeginDrag(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnBeginDrag(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnDrag(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnDrag(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnEndDrag(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnEndDrag(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerDown(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerDown(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ProcessEvent(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			UnityEngine.Event a1;
			checkType(l,2,out a1);
			self.ProcessEvent(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnUpdateSelected(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnUpdateSelected(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Rebuild(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			UnityEngine.UI.CanvasUpdate a1;
			checkEnum(l,2,out a1);
			self.Rebuild(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ActivateInputField(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			self.ActivateInputField();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnSelect(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnSelect(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerClick(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerClick(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DeactivateInputField(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			self.DeactivateInputField();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnDeselect(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnDeselect(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnSubmit(IntPtr l) {
		try{
			UnityEngine.UI.InputField self=checkSelf<UnityEngine.UI.InputField>(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnSubmit(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shouldHideMobileInput(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.shouldHideMobileInput);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shouldHideMobileInput(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.shouldHideMobileInput=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.text);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		System.String v;
		checkType(l,2,out v);
		o.text=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isFocused(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.isFocused);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_caretBlinkRate(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.caretBlinkRate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_caretBlinkRate(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		System.Single v;
		checkType(l,2,out v);
		o.caretBlinkRate=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textComponent(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.textComponent);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textComponent(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		UnityEngine.UI.Text v;
		checkType(l,2,out v);
		o.textComponent=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_placeholder(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.placeholder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_placeholder(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		UnityEngine.UI.Graphic v;
		checkType(l,2,out v);
		o.placeholder=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectionColor(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.selectionColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectionColor(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.selectionColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onEndEdit(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.onEndEdit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onEndEdit(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		UnityEngine.UI.InputField.SubmitEvent v;
		checkType(l,2,out v);
		o.onEndEdit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onValueChange(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.onValueChange);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onValueChange(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		UnityEngine.UI.InputField.OnChangeEvent v;
		checkType(l,2,out v);
		o.onValueChange=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onValidateInput(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onValidateInput(IntPtr l) {
		LuaDLL.luaL_error(l,"Not support");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_characterLimit(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.characterLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_characterLimit(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.characterLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_contentType(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.contentType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_contentType(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		UnityEngine.UI.InputField.ContentType v;
		checkEnum(l,2,out v);
		o.contentType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineType(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.lineType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineType(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		UnityEngine.UI.InputField.LineType v;
		checkEnum(l,2,out v);
		o.lineType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inputType(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.inputType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inputType(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		UnityEngine.UI.InputField.InputType v;
		checkEnum(l,2,out v);
		o.inputType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keyboardType(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.keyboardType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keyboardType(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		UnityEngine.TouchScreenKeyboardType v;
		checkEnum(l,2,out v);
		o.keyboardType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_characterValidation(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.characterValidation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_characterValidation(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		UnityEngine.UI.InputField.CharacterValidation v;
		checkEnum(l,2,out v);
		o.characterValidation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_multiLine(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.multiLine);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asteriskChar(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.asteriskChar);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_asteriskChar(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		System.Char v;
		checkType(l,2,out v);
		o.asteriskChar=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wasCanceled(IntPtr l) {
		UnityEngine.UI.InputField o = checkSelf<UnityEngine.UI.InputField>(l);
		pushValue(l,o.wasCanceled);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.InputField");
		addMember(l,MoveTextEnd, "MoveTextEnd");
		addMember(l,MoveTextStart, "MoveTextStart");
		addMember(l,ScreenToLocal, "ScreenToLocal");
		addMember(l,OnBeginDrag, "OnBeginDrag");
		addMember(l,OnDrag, "OnDrag");
		addMember(l,OnEndDrag, "OnEndDrag");
		addMember(l,OnPointerDown, "OnPointerDown");
		addMember(l,ProcessEvent, "ProcessEvent");
		addMember(l,OnUpdateSelected, "OnUpdateSelected");
		addMember(l,Rebuild, "Rebuild");
		addMember(l,ActivateInputField, "ActivateInputField");
		addMember(l,OnSelect, "OnSelect");
		addMember(l,OnPointerClick, "OnPointerClick");
		addMember(l,DeactivateInputField, "DeactivateInputField");
		addMember(l,OnDeselect, "OnDeselect");
		addMember(l,OnSubmit, "OnSubmit");
		addMember(l,get_shouldHideMobileInput, "get_shouldHideMobileInput");
		addMember(l,set_shouldHideMobileInput, "set_shouldHideMobileInput");
		addMember(l,get_text, "get_text");
		addMember(l,set_text, "set_text");
		addMember(l,get_isFocused, "get_isFocused");
		addMember(l,get_caretBlinkRate, "get_caretBlinkRate");
		addMember(l,set_caretBlinkRate, "set_caretBlinkRate");
		addMember(l,get_textComponent, "get_textComponent");
		addMember(l,set_textComponent, "set_textComponent");
		addMember(l,get_placeholder, "get_placeholder");
		addMember(l,set_placeholder, "set_placeholder");
		addMember(l,get_selectionColor, "get_selectionColor");
		addMember(l,set_selectionColor, "set_selectionColor");
		addMember(l,get_onEndEdit, "get_onEndEdit");
		addMember(l,set_onEndEdit, "set_onEndEdit");
		addMember(l,get_onValueChange, "get_onValueChange");
		addMember(l,set_onValueChange, "set_onValueChange");
		addMember(l,get_onValidateInput, "get_onValidateInput");
		addMember(l,set_onValidateInput, "set_onValidateInput");
		addMember(l,get_characterLimit, "get_characterLimit");
		addMember(l,set_characterLimit, "set_characterLimit");
		addMember(l,get_contentType, "get_contentType");
		addMember(l,set_contentType, "set_contentType");
		addMember(l,get_lineType, "get_lineType");
		addMember(l,set_lineType, "set_lineType");
		addMember(l,get_inputType, "get_inputType");
		addMember(l,set_inputType, "set_inputType");
		addMember(l,get_keyboardType, "get_keyboardType");
		addMember(l,set_keyboardType, "set_keyboardType");
		addMember(l,get_characterValidation, "get_characterValidation");
		addMember(l,set_characterValidation, "set_characterValidation");
		addMember(l,get_multiLine, "get_multiLine");
		addMember(l,get_asteriskChar, "get_asteriskChar");
		addMember(l,set_asteriskChar, "set_asteriskChar");
		addMember(l,get_wasCanceled, "get_wasCanceled");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.InputField),typeof(UnityEngine.UI.Selectable));
		LuaDLL.lua_pop(l, 1);
	}
}
