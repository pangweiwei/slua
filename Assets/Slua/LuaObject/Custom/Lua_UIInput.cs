using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIInput : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIInput o;
		o=new UIInput();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Validate(IntPtr l) {
		try{
			UIInput self=(UIInput)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String ret=self.Validate(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Submit(IntPtr l) {
		try{
			UIInput self=(UIInput)checkSelf(l);
			self.Submit();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateLabel(IntPtr l) {
		try{
			UIInput self=(UIInput)checkSelf(l);
			self.UpdateLabel();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		pushValue(l,UIInput.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		UIInput v;
		checkType(l,2,out v);
		UIInput.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selection(IntPtr l) {
		pushValue(l,UIInput.selection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selection(IntPtr l) {
		UIInput v;
		checkType(l,2,out v);
		UIInput.selection=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_label(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		pushValue(l,o.label);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_label(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		UILabel v;
		checkType(l,2,out v);
		o.label=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inputType(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		pushEnum(l,(int)o.inputType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inputType(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		UIInput.InputType v;
		checkEnum(l,2,out v);
		o.inputType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keyboardType(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		pushEnum(l,(int)o.keyboardType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keyboardType(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		UIInput.KeyboardType v;
		checkEnum(l,2,out v);
		o.keyboardType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_validation(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		pushEnum(l,(int)o.validation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_validation(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		UIInput.Validation v;
		checkEnum(l,2,out v);
		o.validation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_characterLimit(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		pushValue(l,o.characterLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_characterLimit(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.characterLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_savedAs(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		pushValue(l,o.savedAs);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_savedAs(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.savedAs=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectOnTab(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		pushValue(l,o.selectOnTab);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectOnTab(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.selectOnTab=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activeTextColor(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		pushValue(l,o.activeTextColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_activeTextColor(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.activeTextColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_caretColor(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		pushValue(l,o.caretColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_caretColor(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.caretColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectionColor(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		pushValue(l,o.selectionColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectionColor(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.selectionColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onSubmit(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		pushValue(l,o.onSubmit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onSubmit(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onSubmit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onChange(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		pushValue(l,o.onChange);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onChange(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onChange=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onValidate(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		UIInput.OnValidate v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onValidate=v;
		else if(op==1) o.onValidate+=v;
		else if(op==2) o.onValidate-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultText(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		pushValue(l,o.defaultText);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultText(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.defaultText=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		pushValue(l,o.value);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.value=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isSelected(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		pushValue(l,o.isSelected);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isSelected(IntPtr l) {
		UIInput o = (UIInput)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.isSelected=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIInput");
		addMember(l,Validate);
		addMember(l,Submit);
		addMember(l,UpdateLabel);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"selection",get_selection,set_selection,false);
		addMember(l,"label",get_label,set_label,true);
		addMember(l,"inputType",get_inputType,set_inputType,true);
		addMember(l,"keyboardType",get_keyboardType,set_keyboardType,true);
		addMember(l,"validation",get_validation,set_validation,true);
		addMember(l,"characterLimit",get_characterLimit,set_characterLimit,true);
		addMember(l,"savedAs",get_savedAs,set_savedAs,true);
		addMember(l,"selectOnTab",get_selectOnTab,set_selectOnTab,true);
		addMember(l,"activeTextColor",get_activeTextColor,set_activeTextColor,true);
		addMember(l,"caretColor",get_caretColor,set_caretColor,true);
		addMember(l,"selectionColor",get_selectionColor,set_selectionColor,true);
		addMember(l,"onSubmit",get_onSubmit,set_onSubmit,true);
		addMember(l,"onChange",get_onChange,set_onChange,true);
		addMember(l,"onValidate",null,set_onValidate,true);
		addMember(l,"defaultText",get_defaultText,set_defaultText,true);
		addMember(l,"value",get_value,set_value,true);
		addMember(l,"isSelected",get_isSelected,set_isSelected,true);
		createTypeMetatable(l,constructor, typeof(UIInput),typeof(UnityEngine.MonoBehaviour));
	}
}
