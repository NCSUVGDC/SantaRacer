// GENERATED AUTOMATICALLY FROM 'Assets/Controls/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""2b19aaf4-d139-4380-9fd0-0872b912ac2a"",
            ""actions"": [
                {
                    ""name"": ""Speed"",
                    ""type"": ""Value"",
                    ""id"": ""46322845-d084-4731-bd02-10edc77278e8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spin"",
                    ""type"": ""Value"",
                    ""id"": ""3f960bd3-c960-4549-a17b-b90cbbe8d98f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""19262899-79f6-4cf0-9de2-f230e5415322"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChimneyUse"",
                    ""type"": ""Button"",
                    ""id"": ""39815b50-6b97-4350-9bed-3e974497ac98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraRotX"",
                    ""type"": ""Value"",
                    ""id"": ""947a80e1-f523-4dc4-a84a-cd26994d926d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraRotY"",
                    ""type"": ""Value"",
                    ""id"": ""bcc2cfc0-c851-4124-bce3-a935030891ff"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KrampusMove"",
                    ""type"": ""Value"",
                    ""id"": ""9e5fd3ff-eade-494f-9679-fd70c75d3cb9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""abed44bb-9727-4357-9ae9-d03089c2110b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a2caffcf-08d4-4e59-ab8c-9feeca146c60"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Speed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28a056f9-3197-4a50-84f3-5cf3bebeb8ce"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c63af9e0-8048-4a68-8a00-c379928f03a5"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20a1bfb0-6922-4a0a-b21d-89c4e27f8a63"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChimneyUse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""909d2678-bf61-4330-b9a0-4133c22f1acb"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraRotX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0f0fd7b-d5b8-4cc0-838e-9a967e63011b"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraRotY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9b5a70f1-ac3a-48b6-9496-84b9afc5564c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KrampusMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c860e291-c9ca-4a2f-95c2-700fdb3bda60"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KrampusMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dd3e0245-cf62-46d9-9c92-d1e8e72d6eee"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KrampusMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""27083cd0-f931-48e4-b4f6-ad456f3b026d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KrampusMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bf91367d-c137-4237-a480-ff67795ef393"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KrampusMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""784a06ac-5763-42ad-aea0-0863b7cfdbd3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
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
        m_Gameplay_Speed = m_Gameplay.FindAction("Speed", throwIfNotFound: true);
        m_Gameplay_Spin = m_Gameplay.FindAction("Spin", throwIfNotFound: true);
        m_Gameplay_Turn = m_Gameplay.FindAction("Turn", throwIfNotFound: true);
        m_Gameplay_ChimneyUse = m_Gameplay.FindAction("ChimneyUse", throwIfNotFound: true);
        m_Gameplay_CameraRotX = m_Gameplay.FindAction("CameraRotX", throwIfNotFound: true);
        m_Gameplay_CameraRotY = m_Gameplay.FindAction("CameraRotY", throwIfNotFound: true);
        m_Gameplay_KrampusMove = m_Gameplay.FindAction("KrampusMove", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Speed;
    private readonly InputAction m_Gameplay_Spin;
    private readonly InputAction m_Gameplay_Turn;
    private readonly InputAction m_Gameplay_ChimneyUse;
    private readonly InputAction m_Gameplay_CameraRotX;
    private readonly InputAction m_Gameplay_CameraRotY;
    private readonly InputAction m_Gameplay_KrampusMove;
    private readonly InputAction m_Gameplay_Jump;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Speed => m_Wrapper.m_Gameplay_Speed;
        public InputAction @Spin => m_Wrapper.m_Gameplay_Spin;
        public InputAction @Turn => m_Wrapper.m_Gameplay_Turn;
        public InputAction @ChimneyUse => m_Wrapper.m_Gameplay_ChimneyUse;
        public InputAction @CameraRotX => m_Wrapper.m_Gameplay_CameraRotX;
        public InputAction @CameraRotY => m_Wrapper.m_Gameplay_CameraRotY;
        public InputAction @KrampusMove => m_Wrapper.m_Gameplay_KrampusMove;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Speed.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeed;
                @Speed.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeed;
                @Speed.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeed;
                @Spin.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpin;
                @Spin.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpin;
                @Spin.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpin;
                @Turn.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTurn;
                @ChimneyUse.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChimneyUse;
                @ChimneyUse.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChimneyUse;
                @ChimneyUse.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChimneyUse;
                @CameraRotX.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraRotX;
                @CameraRotX.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraRotX;
                @CameraRotX.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraRotX;
                @CameraRotY.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraRotY;
                @CameraRotY.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraRotY;
                @CameraRotY.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraRotY;
                @KrampusMove.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKrampusMove;
                @KrampusMove.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKrampusMove;
                @KrampusMove.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKrampusMove;
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Speed.started += instance.OnSpeed;
                @Speed.performed += instance.OnSpeed;
                @Speed.canceled += instance.OnSpeed;
                @Spin.started += instance.OnSpin;
                @Spin.performed += instance.OnSpin;
                @Spin.canceled += instance.OnSpin;
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
                @ChimneyUse.started += instance.OnChimneyUse;
                @ChimneyUse.performed += instance.OnChimneyUse;
                @ChimneyUse.canceled += instance.OnChimneyUse;
                @CameraRotX.started += instance.OnCameraRotX;
                @CameraRotX.performed += instance.OnCameraRotX;
                @CameraRotX.canceled += instance.OnCameraRotX;
                @CameraRotY.started += instance.OnCameraRotY;
                @CameraRotY.performed += instance.OnCameraRotY;
                @CameraRotY.canceled += instance.OnCameraRotY;
                @KrampusMove.started += instance.OnKrampusMove;
                @KrampusMove.performed += instance.OnKrampusMove;
                @KrampusMove.canceled += instance.OnKrampusMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnSpeed(InputAction.CallbackContext context);
        void OnSpin(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
        void OnChimneyUse(InputAction.CallbackContext context);
        void OnCameraRotX(InputAction.CallbackContext context);
        void OnCameraRotY(InputAction.CallbackContext context);
        void OnKrampusMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
