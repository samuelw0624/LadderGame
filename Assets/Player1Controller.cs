//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Player1Controller.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Player1Controller : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player1Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player1Controller"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""c36803d6-494e-4583-84ad-347a27cb42c0"",
            ""actions"": [
                {
                    ""name"": ""Climb"",
                    ""type"": ""Button"",
                    ""id"": ""66c9b3ec-c711-4e0b-a7af-fd1e5d91242b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move_X"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fb3639c7-e723-4494-9f2b-1a53c656510d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hold"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1e726c96-68a3-4e67-be64-1686f0848237"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Equip01"",
                    ""type"": ""Button"",
                    ""id"": ""16241a9b-689e-46b6-98a7-6882f405b1e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Equip02"",
                    ""type"": ""Button"",
                    ""id"": ""1da41566-0bb9-47c3-8016-bfff8c2f9042"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Equip03"",
                    ""type"": ""Button"",
                    ""id"": ""8cc51995-a5a1-4a9e-9750-b4e56c3272bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0c260b49-97c2-42c3-9a1b-15bff8586035"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Climb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e8bf63c-9bdf-46c1-ac8b-02203d4f26e7"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Climb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""926d1d9b-40c5-4202-ab13-b50dc95f918c"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20ed4670-415c-477a-9fd4-b073ffb9bd5e"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e033450-f296-4dd9-aae0-8b271675cfc7"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32b723dc-54ea-40ef-b6da-24508a4618e8"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Equip01"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac8b0748-d6ec-4a3f-a94a-2e0daf29d7df"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Equip02"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25739ddb-d824-48a1-93fc-3702fe44a475"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Equip03"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Climb = m_Gameplay.FindAction("Climb", throwIfNotFound: true);
        m_Gameplay_Move_X = m_Gameplay.FindAction("Move_X", throwIfNotFound: true);
        m_Gameplay_Hold = m_Gameplay.FindAction("Hold", throwIfNotFound: true);
        m_Gameplay_Equip01 = m_Gameplay.FindAction("Equip01", throwIfNotFound: true);
        m_Gameplay_Equip02 = m_Gameplay.FindAction("Equip02", throwIfNotFound: true);
        m_Gameplay_Equip03 = m_Gameplay.FindAction("Equip03", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Climb;
    private readonly InputAction m_Gameplay_Move_X;
    private readonly InputAction m_Gameplay_Hold;
    private readonly InputAction m_Gameplay_Equip01;
    private readonly InputAction m_Gameplay_Equip02;
    private readonly InputAction m_Gameplay_Equip03;
    public struct GameplayActions
    {
        private @Player1Controller m_Wrapper;
        public GameplayActions(@Player1Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Climb => m_Wrapper.m_Gameplay_Climb;
        public InputAction @Move_X => m_Wrapper.m_Gameplay_Move_X;
        public InputAction @Hold => m_Wrapper.m_Gameplay_Hold;
        public InputAction @Equip01 => m_Wrapper.m_Gameplay_Equip01;
        public InputAction @Equip02 => m_Wrapper.m_Gameplay_Equip02;
        public InputAction @Equip03 => m_Wrapper.m_Gameplay_Equip03;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Climb.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnClimb;
                @Climb.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnClimb;
                @Climb.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnClimb;
                @Move_X.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove_X;
                @Move_X.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove_X;
                @Move_X.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove_X;
                @Hold.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHold;
                @Hold.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHold;
                @Hold.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHold;
                @Equip01.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEquip01;
                @Equip01.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEquip01;
                @Equip01.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEquip01;
                @Equip02.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEquip02;
                @Equip02.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEquip02;
                @Equip02.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEquip02;
                @Equip03.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEquip03;
                @Equip03.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEquip03;
                @Equip03.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEquip03;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Climb.started += instance.OnClimb;
                @Climb.performed += instance.OnClimb;
                @Climb.canceled += instance.OnClimb;
                @Move_X.started += instance.OnMove_X;
                @Move_X.performed += instance.OnMove_X;
                @Move_X.canceled += instance.OnMove_X;
                @Hold.started += instance.OnHold;
                @Hold.performed += instance.OnHold;
                @Hold.canceled += instance.OnHold;
                @Equip01.started += instance.OnEquip01;
                @Equip01.performed += instance.OnEquip01;
                @Equip01.canceled += instance.OnEquip01;
                @Equip02.started += instance.OnEquip02;
                @Equip02.performed += instance.OnEquip02;
                @Equip02.canceled += instance.OnEquip02;
                @Equip03.started += instance.OnEquip03;
                @Equip03.performed += instance.OnEquip03;
                @Equip03.canceled += instance.OnEquip03;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnClimb(InputAction.CallbackContext context);
        void OnMove_X(InputAction.CallbackContext context);
        void OnHold(InputAction.CallbackContext context);
        void OnEquip01(InputAction.CallbackContext context);
        void OnEquip02(InputAction.CallbackContext context);
        void OnEquip03(InputAction.CallbackContext context);
    }
}
