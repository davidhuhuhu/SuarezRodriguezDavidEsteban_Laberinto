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
                    ""path"": ""<Gamepad>/leftStick/y"",
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
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JSL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Bola"",
            ""id"": ""d1b72cbf-6e62-442b-bef7-4deaa0b002e7"",
            ""actions"": [
                {
                    ""name"": ""Keys"",
                    ""type"": ""Value"",
                    ""id"": ""d850790f-3b76-4450-b763-37d4adecc271"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Keys2"",
                    ""type"": ""Value"",
                    ""id"": ""170d0bdb-7307-4ba0-885c-c87816c6deaa"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""60dee5b0-3be6-4680-9d82-336f5e175891"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keys"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e28ce16a-8d2a-4a50-842d-3d0a943263ba"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""208b1a36-4c59-4fa2-bb5a-41d4de429668"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""503e708b-4894-4b3a-b6ae-ec5f0750d1fe"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c5734ab6-1fba-4b16-bdb7-ed7261373484"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keys2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e499c893-7fb8-42b4-bb9c-15cf94147da6"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keys2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cbc072df-4fc1-4356-bc33-495759edbc00"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keys2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c0c0ced7-40bf-4f2a-9d7b-3c9b4e284be1"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keys2"",
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
        // Bola
        m_Bola = asset.FindActionMap("Bola", throwIfNotFound: true);
        m_Bola_Keys = m_Bola.FindAction("Keys", throwIfNotFound: true);
        m_Bola_Keys2 = m_Bola.FindAction("Keys2", throwIfNotFound: true);
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

    // Bola
    private readonly InputActionMap m_Bola;
    private IBolaActions m_BolaActionsCallbackInterface;
    private readonly InputAction m_Bola_Keys;
    private readonly InputAction m_Bola_Keys2;
    public struct BolaActions
    {
        private @InputSystem m_Wrapper;
        public BolaActions(@InputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Keys => m_Wrapper.m_Bola_Keys;
        public InputAction @Keys2 => m_Wrapper.m_Bola_Keys2;
        public InputActionMap Get() { return m_Wrapper.m_Bola; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BolaActions set) { return set.Get(); }
        public void SetCallbacks(IBolaActions instance)
        {
            if (m_Wrapper.m_BolaActionsCallbackInterface != null)
            {
                @Keys.started -= m_Wrapper.m_BolaActionsCallbackInterface.OnKeys;
                @Keys.performed -= m_Wrapper.m_BolaActionsCallbackInterface.OnKeys;
                @Keys.canceled -= m_Wrapper.m_BolaActionsCallbackInterface.OnKeys;
                @Keys2.started -= m_Wrapper.m_BolaActionsCallbackInterface.OnKeys2;
                @Keys2.performed -= m_Wrapper.m_BolaActionsCallbackInterface.OnKeys2;
                @Keys2.canceled -= m_Wrapper.m_BolaActionsCallbackInterface.OnKeys2;
            }
            m_Wrapper.m_BolaActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Keys.started += instance.OnKeys;
                @Keys.performed += instance.OnKeys;
                @Keys.canceled += instance.OnKeys;
                @Keys2.started += instance.OnKeys2;
                @Keys2.performed += instance.OnKeys2;
                @Keys2.canceled += instance.OnKeys2;
            }
        }
    }
    public BolaActions @Bola => new BolaActions(this);
    public interface IFloorActions
    {
        void OnJSR(InputAction.CallbackContext context);
        void OnJSL(InputAction.CallbackContext context);
    }
    public interface IBolaActions
    {
        void OnKeys(InputAction.CallbackContext context);
        void OnKeys2(InputAction.CallbackContext context);
    }
}
