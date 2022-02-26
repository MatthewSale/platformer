// GENERATED AUTOMATICALLY FROM 'Assets/Input system/PlayerControllsMain.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControllsMain : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControllsMain()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControllsMain"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""cf0f8392-4f32-40bd-9343-e774c194957b"",
            ""actions"": [
                {
                    ""name"": ""rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c90ae608-85f9-4a63-90ec-5cf799b5d689"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ForwardMovement"",
                    ""type"": ""Button"",
                    ""id"": ""8deca04f-aa6a-4022-96a2-acb01240c502"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftMovement"",
                    ""type"": ""Button"",
                    ""id"": ""836d4062-0775-45dd-b713-55a34933dc9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightMovement"",
                    ""type"": ""Button"",
                    ""id"": ""cadf363e-d3c7-4274-8c5e-9e9444fe29eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackMovement"",
                    ""type"": ""Button"",
                    ""id"": ""2227f928-c1e0-4aa9-a001-d6aedb511ae7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FirewormholeGun"",
                    ""type"": ""Button"",
                    ""id"": ""53c54d98-8ccd-4782-aec4-7b7ff83ccde2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c209ae87-a16a-419e-a2d4-8b6fccef909a"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d8fd989-9719-4698-b07f-6d6778e8e467"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9dc3c48e-332e-4817-aa1d-40f528bc7ad4"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9cb2b1c-15ae-48bc-a820-12e1d58bd944"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cda8a1ed-a95f-450c-8ee6-3858678f279f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a6840a5-c0e1-4587-81c0-293fd822b114"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48a83c25-7b7c-4db7-baf4-73e20eb94bd5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FirewormholeGun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0aa64f87-cbd0-4b4c-8dd3-8a0ee558e5c3"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FirewormholeGun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_rotate = m_GamePlay.FindAction("rotate", throwIfNotFound: true);
        m_GamePlay_ForwardMovement = m_GamePlay.FindAction("ForwardMovement", throwIfNotFound: true);
        m_GamePlay_LeftMovement = m_GamePlay.FindAction("LeftMovement", throwIfNotFound: true);
        m_GamePlay_RightMovement = m_GamePlay.FindAction("RightMovement", throwIfNotFound: true);
        m_GamePlay_BackMovement = m_GamePlay.FindAction("BackMovement", throwIfNotFound: true);
        m_GamePlay_FirewormholeGun = m_GamePlay.FindAction("FirewormholeGun", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_rotate;
    private readonly InputAction m_GamePlay_ForwardMovement;
    private readonly InputAction m_GamePlay_LeftMovement;
    private readonly InputAction m_GamePlay_RightMovement;
    private readonly InputAction m_GamePlay_BackMovement;
    private readonly InputAction m_GamePlay_FirewormholeGun;
    public struct GamePlayActions
    {
        private @PlayerControllsMain m_Wrapper;
        public GamePlayActions(@PlayerControllsMain wrapper) { m_Wrapper = wrapper; }
        public InputAction @rotate => m_Wrapper.m_GamePlay_rotate;
        public InputAction @ForwardMovement => m_Wrapper.m_GamePlay_ForwardMovement;
        public InputAction @LeftMovement => m_Wrapper.m_GamePlay_LeftMovement;
        public InputAction @RightMovement => m_Wrapper.m_GamePlay_RightMovement;
        public InputAction @BackMovement => m_Wrapper.m_GamePlay_BackMovement;
        public InputAction @FirewormholeGun => m_Wrapper.m_GamePlay_FirewormholeGun;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @rotate.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRotate;
                @rotate.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRotate;
                @rotate.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRotate;
                @ForwardMovement.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnForwardMovement;
                @ForwardMovement.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnForwardMovement;
                @ForwardMovement.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnForwardMovement;
                @LeftMovement.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLeftMovement;
                @LeftMovement.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLeftMovement;
                @LeftMovement.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLeftMovement;
                @RightMovement.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRightMovement;
                @RightMovement.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRightMovement;
                @RightMovement.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRightMovement;
                @BackMovement.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBackMovement;
                @BackMovement.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBackMovement;
                @BackMovement.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBackMovement;
                @FirewormholeGun.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnFirewormholeGun;
                @FirewormholeGun.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnFirewormholeGun;
                @FirewormholeGun.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnFirewormholeGun;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @rotate.started += instance.OnRotate;
                @rotate.performed += instance.OnRotate;
                @rotate.canceled += instance.OnRotate;
                @ForwardMovement.started += instance.OnForwardMovement;
                @ForwardMovement.performed += instance.OnForwardMovement;
                @ForwardMovement.canceled += instance.OnForwardMovement;
                @LeftMovement.started += instance.OnLeftMovement;
                @LeftMovement.performed += instance.OnLeftMovement;
                @LeftMovement.canceled += instance.OnLeftMovement;
                @RightMovement.started += instance.OnRightMovement;
                @RightMovement.performed += instance.OnRightMovement;
                @RightMovement.canceled += instance.OnRightMovement;
                @BackMovement.started += instance.OnBackMovement;
                @BackMovement.performed += instance.OnBackMovement;
                @BackMovement.canceled += instance.OnBackMovement;
                @FirewormholeGun.started += instance.OnFirewormholeGun;
                @FirewormholeGun.performed += instance.OnFirewormholeGun;
                @FirewormholeGun.canceled += instance.OnFirewormholeGun;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    public interface IGamePlayActions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnForwardMovement(InputAction.CallbackContext context);
        void OnLeftMovement(InputAction.CallbackContext context);
        void OnRightMovement(InputAction.CallbackContext context);
        void OnBackMovement(InputAction.CallbackContext context);
        void OnFirewormholeGun(InputAction.CallbackContext context);
    }
}
