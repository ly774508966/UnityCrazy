﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using UnityEngine;
using LuaInterface;

public static class LuaBinder
{
	public static void Bind(LuaState L)
	{
		float t = Time.realtimeSinceStartup;
		L.BeginModule(null);
		LuaInterface_DebuggerWrap.Register(L);
		UIGridWrap.Register(L);
		UIWidgetContainerWrap.Register(L);
		L.BeginModule("UnityEngine");
		UnityEngine_ResourcesWrap.Register(L);
		UnityEngine_SpriteRendererWrap.Register(L);
		UnityEngine_ComponentWrap.Register(L);
		UnityEngine_TransformWrap.Register(L);
		UnityEngine_MaterialWrap.Register(L);
		UnityEngine_LightWrap.Register(L);
		UnityEngine_CameraWrap.Register(L);
		UnityEngine_AudioSourceWrap.Register(L);
		UnityEngine_BehaviourWrap.Register(L);
		UnityEngine_MonoBehaviourWrap.Register(L);
		UnityEngine_GameObjectWrap.Register(L);
		UnityEngine_TrackedReferenceWrap.Register(L);
		UnityEngine_ApplicationWrap.Register(L);
		UnityEngine_PhysicsWrap.Register(L);
		UnityEngine_ColliderWrap.Register(L);
		UnityEngine_TimeWrap.Register(L);
		UnityEngine_TextureWrap.Register(L);
		UnityEngine_Texture2DWrap.Register(L);
		UnityEngine_ShaderWrap.Register(L);
		UnityEngine_RendererWrap.Register(L);
		UnityEngine_WWWWrap.Register(L);
		UnityEngine_ScreenWrap.Register(L);
		UnityEngine_CameraClearFlagsWrap.Register(L);
		UnityEngine_AudioClipWrap.Register(L);
		UnityEngine_AssetBundleWrap.Register(L);
		UnityEngine_ParticleSystemWrap.Register(L);
		UnityEngine_AsyncOperationWrap.Register(L);
		UnityEngine_LightTypeWrap.Register(L);
		UnityEngine_SleepTimeoutWrap.Register(L);
		UnityEngine_AnimatorWrap.Register(L);
		UnityEngine_InputWrap.Register(L);
		UnityEngine_KeyCodeWrap.Register(L);
		UnityEngine_SkinnedMeshRendererWrap.Register(L);
		UnityEngine_SpaceWrap.Register(L);
		UnityEngine_AnimationBlendModeWrap.Register(L);
		UnityEngine_QueueModeWrap.Register(L);
		UnityEngine_PlayModeWrap.Register(L);
		UnityEngine_WrapModeWrap.Register(L);
		UnityEngine_QualitySettingsWrap.Register(L);
		UnityEngine_RenderSettingsWrap.Register(L);
		L.BeginModule("UI");
		UnityEngine_UI_ButtonWrap.Register(L);
		UnityEngine_UI_TextWrap.Register(L);
		UnityEngine_UI_MaskableGraphicWrap.Register(L);
		UnityEngine_UI_GraphicWrap.Register(L);
		UnityEngine_UI_ImageWrap.Register(L);
		UnityEngine_UI_ToggleGroupWrap.Register(L);
		UnityEngine_UI_ToggleWrap.Register(L);
		UnityEngine_UI_ScrollRectWrap.Register(L);
		UnityEngine_UI_InputFieldWrap.Register(L);
		UnityEngine_UI_DropdownWrap.Register(L);
		UnityEngine_UI_SliderWrap.Register(L);
		UnityEngine_UI_SelectableWrap.Register(L);
		L.BeginModule("Button");
		UnityEngine_UI_Button_ButtonClickedEventWrap.Register(L);
		L.EndModule();
		L.BeginModule("Toggle");
		UnityEngine_UI_Toggle_ToggleEventWrap.Register(L);
		L.EndModule();
		L.BeginModule("Dropdown");
		UnityEngine_UI_Dropdown_DropdownEventWrap.Register(L);
		UnityEngine_UI_Dropdown_OptionDataWrap.Register(L);
		L.EndModule();
		L.BeginModule("Slider");
		UnityEngine_UI_Slider_SliderEventWrap.Register(L);
		L.EndModule();
		L.BeginModule("InputField");
		L.RegFunction("OnValidateInput", UnityEngine_UI_InputField_OnValidateInput);
		L.EndModule();
		L.EndModule();
		L.BeginModule("Events");
		UnityEngine_Events_UnityEventBaseWrap.Register(L);
		UnityEngine_Events_UnityEventWrap.Register(L);
		UnityEngine_Events_UnityEvent_boolWrap.Register(L);
		UnityEngine_Events_UnityEvent_intWrap.Register(L);
		UnityEngine_Events_UnityEvent_floatWrap.Register(L);
		L.RegFunction("UnityAction", UnityEngine_Events_UnityAction);
		L.RegFunction("UnityAction_bool", UnityEngine_Events_UnityAction_bool);
		L.RegFunction("UnityAction_int", UnityEngine_Events_UnityAction_int);
		L.RegFunction("UnityAction_float", UnityEngine_Events_UnityAction_float);
		L.EndModule();
		L.BeginModule("EventSystems");
		UnityEngine_EventSystems_UIBehaviourWrap.Register(L);
		UnityEngine_EventSystems_PointerEventDataWrap.Register(L);
		UnityEngine_EventSystems_BaseEventDataWrap.Register(L);
		UnityEngine_EventSystems_AbstractEventDataWrap.Register(L);
		L.EndModule();
		L.BeginModule("Experimental");
		L.BeginModule("Director");
		UnityEngine_Experimental_Director_DirectorPlayerWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("Camera");
		L.RegFunction("CameraCallback", UnityEngine_Camera_CameraCallback);
		L.EndModule();
		L.BeginModule("Application");
		L.RegFunction("AdvertisingIdentifierCallback", UnityEngine_Application_AdvertisingIdentifierCallback);
		L.RegFunction("LogCallback", UnityEngine_Application_LogCallback);
		L.EndModule();
		L.BeginModule("AudioClip");
		L.RegFunction("PCMReaderCallback", UnityEngine_AudioClip_PCMReaderCallback);
		L.RegFunction("PCMSetPositionCallback", UnityEngine_AudioClip_PCMSetPositionCallback);
		L.EndModule();
		L.EndModule();
		L.BeginModule("System");
		L.RegFunction("Action", System_Action);
		L.RegFunction("Predicate_int", System_Predicate_int);
		L.RegFunction("Action_int", System_Action_int);
		L.RegFunction("Comparison_int", System_Comparison_int);
		L.RegFunction("Comparison_UnityEngine_Transform", System_Comparison_UnityEngine_Transform);
		L.EndModule();
		L.BeginModule("UIGrid");
		L.RegFunction("OnReposition", UIGrid_OnReposition);
		L.EndModule();
		L.EndModule();
		L.BeginPreLoad();
		L.AddPreLoad("UnityEngine.MeshRenderer", LuaOpen_UnityEngine_MeshRenderer, typeof(UnityEngine.MeshRenderer));
		L.AddPreLoad("UnityEngine.ParticleEmitter", LuaOpen_UnityEngine_ParticleEmitter, typeof(UnityEngine.ParticleEmitter));
		L.AddPreLoad("UnityEngine.ParticleRenderer", LuaOpen_UnityEngine_ParticleRenderer, typeof(UnityEngine.ParticleRenderer));
		L.AddPreLoad("UnityEngine.ParticleAnimator", LuaOpen_UnityEngine_ParticleAnimator, typeof(UnityEngine.ParticleAnimator));
		L.AddPreLoad("UnityEngine.BoxCollider", LuaOpen_UnityEngine_BoxCollider, typeof(UnityEngine.BoxCollider));
		L.AddPreLoad("UnityEngine.MeshCollider", LuaOpen_UnityEngine_MeshCollider, typeof(UnityEngine.MeshCollider));
		L.AddPreLoad("UnityEngine.SphereCollider", LuaOpen_UnityEngine_SphereCollider, typeof(UnityEngine.SphereCollider));
		L.AddPreLoad("UnityEngine.CharacterController", LuaOpen_UnityEngine_CharacterController, typeof(UnityEngine.CharacterController));
		L.AddPreLoad("UnityEngine.CapsuleCollider", LuaOpen_UnityEngine_CapsuleCollider, typeof(UnityEngine.CapsuleCollider));
		L.AddPreLoad("UnityEngine.Animation", LuaOpen_UnityEngine_Animation, typeof(UnityEngine.Animation));
		L.AddPreLoad("UnityEngine.AnimationClip", LuaOpen_UnityEngine_AnimationClip, typeof(UnityEngine.AnimationClip));
		L.AddPreLoad("UnityEngine.AnimationState", LuaOpen_UnityEngine_AnimationState, typeof(UnityEngine.AnimationState));
		L.AddPreLoad("UnityEngine.BlendWeights", LuaOpen_UnityEngine_BlendWeights, typeof(UnityEngine.BlendWeights));
		L.AddPreLoad("UnityEngine.RenderTexture", LuaOpen_UnityEngine_RenderTexture, typeof(UnityEngine.RenderTexture));
		L.AddPreLoad("UnityEngine.Rigidbody", LuaOpen_UnityEngine_Rigidbody, typeof(UnityEngine.Rigidbody));
		L.EndPreLoad();
		Debugger.Log("Register lua type cost time: {0}", Time.realtimeSinceStartup - t);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_UI_InputField_OnValidateInput(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.UI.InputField.OnValidateInput), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.UI.InputField.OnValidateInput), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_bool(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<bool>), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<bool>), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_int(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<int>), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<int>), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_float(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<float>), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<float>), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Camera_CameraCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Camera.CameraCallback), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Camera.CameraCallback), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Application_AdvertisingIdentifierCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Application.AdvertisingIdentifierCallback), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Application.AdvertisingIdentifierCallback), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Application_LogCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Application.LogCallback), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Application.LogCallback), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_AudioClip_PCMReaderCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.AudioClip.PCMReaderCallback), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.AudioClip.PCMReaderCallback), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_AudioClip_PCMSetPositionCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.AudioClip.PCMSetPositionCallback), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.AudioClip.PCMSetPositionCallback), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Predicate_int(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Predicate<int>), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Predicate<int>), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_int(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<int>), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<int>), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Comparison_int(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Comparison<int>), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Comparison<int>), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Comparison_UnityEngine_Transform(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Comparison<UnityEngine.Transform>), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Comparison<UnityEngine.Transform>), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UIGrid_OnReposition(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UIGrid.OnReposition), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UIGrid.OnReposition), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_MeshRenderer(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_MeshRendererWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.MeshRenderer));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_ParticleEmitter(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_ParticleEmitterWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.ParticleEmitter));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_ParticleRenderer(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_ParticleRendererWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.ParticleRenderer));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_ParticleAnimator(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_ParticleAnimatorWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.ParticleAnimator));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_BoxCollider(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_BoxColliderWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.BoxCollider));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_MeshCollider(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_MeshColliderWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.MeshCollider));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_SphereCollider(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_SphereColliderWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.SphereCollider));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_CharacterController(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_CharacterControllerWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.CharacterController));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_CapsuleCollider(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_CapsuleColliderWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.CapsuleCollider));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_Animation(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_AnimationWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.Animation));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_AnimationClip(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_AnimationClipWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.AnimationClip));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_AnimationState(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_AnimationStateWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.AnimationState));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_BlendWeights(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_BlendWeightsWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.BlendWeights));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_RenderTexture(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_RenderTextureWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.RenderTexture));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaOpen_UnityEngine_Rigidbody(IntPtr L)
	{
		try
		{
			LuaState state = LuaState.Get(L);
			state.BeginPreModule("UnityEngine");
			UnityEngine_RigidbodyWrap.Register(state);
			int reference = state.GetMetaReference(typeof(UnityEngine.Rigidbody));
			state.EndPreModule(L, reference);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

