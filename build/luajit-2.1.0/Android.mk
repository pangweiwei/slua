LOCAL_PATH := $(call my-dir)
include $(CLEAR_VARS)
LOCAL_LDLIBS := $(LOCAL_PATH)/libluajit.a
LOCAL_MODULE    := slua
include $(BUILD_SHARED_LIBRARY)
