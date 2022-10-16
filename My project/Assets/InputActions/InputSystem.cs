// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/InputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""Floor"",
            ""id"": ""f790c229-7cf5-4bea-aa81-9cadb5b1cd10"",
            ""actions"": [
                {
                    ""name"": ""JSR"",
                    ""type"": ""Value"",
                    ""id"": ""907fd651-549c-4ba0-9cac-c19cf1788fc9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JSL"",
                    ""type"": ""Value"",
                    ""id"": ""cbeb29c5-a289-439c-a8ad-46a1cf00c848"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""61795a37-9184-446d-9224-66dca3a9be10"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JSR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44759000-2719-4664-91e2-e24800ec9310"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JSL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Floor
        m_Floor = asset.FindActionMap("Floor", throwIfNotFound: true);
        m_Floor_JSR = m_Floor.FindAction("JSR", throwIfNotFound: true);
        m_Floor_JSL = m_Floor.FindAction("JSL", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Floor
    private readonly InputActionMap m_Floor;
    private IFloorActions m_FloorActionsCallbackInterface;
    private readonly InputAction m_Floor_JSR;
    private readonly InputAction m_Floor_JSL;
    public struct FloorActions
    {
        private @InputSystem m_Wrapper;
        public FloorActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @JSR => m_Wrapper.m_Floor_JSR;
        public InputAction @JSL => m_Wrapper.m_Floor_JSL;
        public InputActionMap Get() { return m_Wrapper.m_Floor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FloorActions set) { return set.Get(); }
        public void SetCallbacks(IFloorActions instance)
        {
            if (m_Wrapper.m_FloorActionsCallbackInterface != null)
            {
                @JSR.started -= m_Wrapper.m_FloorActionsCallbackInterface.OnJSR;
                @JSR.performed -= m_Wrapper.m_FloorActionsCallbackInterface.OnJSR;
                @JSR.canceled -= m_Wrapper.m_FloorActionsCallbackInterface.OnJSR;
                @JSL.started -= m_Wrapper.m_FloorActionsCallbackInterface.OnJSL;
                @JSL.performed -= m_Wrapper.m_FloorActionsCallbackInterface.OnJSL;
                @JSL.canceled -= m_Wrapper.m_FloorActionsCallbackInterface.OnJSL;
            }
            m_Wrapper.m_FloorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @JSR.started += instance.OnJSR;
                @JSR.performed += instance.OnJSR;
                @JSR.canceled += instance.OnJSR;
                @JSL.started += instance.OnJSL;
                @JSL.performed += instance.OnJSL;
                @JSL.canceled += instance.OnJSL;
            }
        }
    }
    public FloorActions @Floor => new FloorActions(this);
    public interface IFloorActions
    {
        void OnJSR(InputAction.CallbackContext context);
        void OnJSL(InputAction.CallbackContext context);
    }
}
