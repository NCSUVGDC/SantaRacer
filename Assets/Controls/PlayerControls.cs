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
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""e452e71d-216d-4585-9e3c-e7253e4b4daf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KrampusAttack1"",
                    ""type"": ""Button"",
                    ""id"": ""82d6c354-1a37-42cc-a212-3cdf2d641291"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SantaTrapW"",
                    ""type"": ""Button"",
                    ""id"": ""56277d50-f987-4ccb-8d8a-a80802bc17e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CycleTrapsR"",
                    ""type"": ""Button"",
                    ""id"": ""2dab7caf-16be-4e68-8b46-42b2c5085600"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CycleTrapsL"",
                    ""type"": ""Button"",
                    ""id"": ""d3834339-aeaf-4045-8f2a-2e6a7cbc8f27"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SantaTrapN"",
                    ""type"": ""Button"",
                    ""id"": ""a0c23572-1a8a-439d-b87d-529c3faae923"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SantaTrapE"",
                    ""type"": ""Button"",
                    ""id"": ""454bb12b-dbf3-4abd-ad2e-11eee0b147d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KrampusAttack2"",
                    ""type"": ""Button"",
                    ""id"": ""c777c396-29b9-40e7-8738-34fcd4201bef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KrampusAttack3"",
                    ""type"": ""Button"",
                    ""id"": ""8c32190e-3cb1-4a8d-92a9-87807a56c927"",
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
                    ""path"": ""<Gamepad>/buttonSouth"",
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
                    ""id"": ""fbfea11c-6c0d-459d-a88c-5df5c5734723"",
                    ""path"": ""<Gamepad>/rightStick/x"",
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
                    ""name"": """",
                    ""id"": ""18680b88-564a-448e-be9e-3759e51e7af3"",
                    ""path"": ""<Gamepad>/rightStick/y"",
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
                    ""id"": ""fb3ae668-be02-4caf-91df-9eedc91a9f34"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KrampusMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
                },
                {
                    ""name"": """",
                    ""id"": ""29250b5c-ac34-401f-b14c-5ae1fe1dccb5"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31bb6a30-d12f-4bab-963f-00363eb0d246"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f707c410-c4f8-4deb-9428-bb00f10da0a4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93dfab70-f032-4762-a584-b9fe8b02be18"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KrampusAttack1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32909eb6-4e11-48fe-8314-39d686cf5121"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SantaTrapW"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7400c4ad-d5c8-4064-b359-9590a4a10bf7"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CycleTrapsR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""301dae57-74e7-4e54-8dfd-e4bd99e6fd1c"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CycleTrapsL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfcec838-0ce1-43cb-8cb9-d9d5a2a34e0e"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SantaTrapN"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12c378ed-bc44-4f61-b40f-693115734d0c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SantaTrapE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14ed9c59-b320-4eb6-b61b-f73443ab34ef"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KrampusAttack2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""727c15e6-c1de-4161-91b7-17deda38da40"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KrampusAttack3"",
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
        m_Gameplay_Interact = m_Gameplay.FindAction("Interact", throwIfNotFound: true);
        m_Gameplay_KrampusAttack1 = m_Gameplay.FindAction("KrampusAttack1", throwIfNotFound: true);
        m_Gameplay_SantaTrapW = m_Gameplay.FindAction("SantaTrapW", throwIfNotFound: true);
        m_Gameplay_CycleTrapsR = m_Gameplay.FindAction("CycleTrapsR", throwIfNotFound: true);
        m_Gameplay_CycleTrapsL = m_Gameplay.FindAction("CycleTrapsL", throwIfNotFound: true);
        m_Gameplay_SantaTrapN = m_Gameplay.FindAction("SantaTrapN", throwIfNotFound: true);
        m_Gameplay_SantaTrapE = m_Gameplay.FindAction("SantaTrapE", throwIfNotFound: true);
        m_Gameplay_KrampusAttack2 = m_Gameplay.FindAction("KrampusAttack2", throwIfNotFound: true);
        m_Gameplay_KrampusAttack3 = m_Gameplay.FindAction("KrampusAttack3", throwIfNotFound: true);
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
    private readonly InputAction m_Gameplay_Interact;
    private readonly InputAction m_Gameplay_KrampusAttack1;
    private readonly InputAction m_Gameplay_SantaTrapW;
    private readonly InputAction m_Gameplay_CycleTrapsR;
    private readonly InputAction m_Gameplay_CycleTrapsL;
    private readonly InputAction m_Gameplay_SantaTrapN;
    private readonly InputAction m_Gameplay_SantaTrapE;
    private readonly InputAction m_Gameplay_KrampusAttack2;
    private readonly InputAction m_Gameplay_KrampusAttack3;
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
        public InputAction @Interact => m_Wrapper.m_Gameplay_Interact;
        public InputAction @KrampusAttack1 => m_Wrapper.m_Gameplay_KrampusAttack1;
        public InputAction @SantaTrapW => m_Wrapper.m_Gameplay_SantaTrapW;
        public InputAction @CycleTrapsR => m_Wrapper.m_Gameplay_CycleTrapsR;
        public InputAction @CycleTrapsL => m_Wrapper.m_Gameplay_CycleTrapsL;
        public InputAction @SantaTrapN => m_Wrapper.m_Gameplay_SantaTrapN;
        public InputAction @SantaTrapE => m_Wrapper.m_Gameplay_SantaTrapE;
        public InputAction @KrampusAttack2 => m_Wrapper.m_Gameplay_KrampusAttack2;
        public InputAction @KrampusAttack3 => m_Wrapper.m_Gameplay_KrampusAttack3;
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
                @Interact.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                @KrampusAttack1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKrampusAttack1;
                @KrampusAttack1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKrampusAttack1;
                @KrampusAttack1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKrampusAttack1;
                @SantaTrapW.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSantaTrapW;
                @SantaTrapW.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSantaTrapW;
                @SantaTrapW.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSantaTrapW;
                @CycleTrapsR.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCycleTrapsR;
                @CycleTrapsR.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCycleTrapsR;
                @CycleTrapsR.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCycleTrapsR;
                @CycleTrapsL.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCycleTrapsL;
                @CycleTrapsL.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCycleTrapsL;
                @CycleTrapsL.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCycleTrapsL;
                @SantaTrapN.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSantaTrapN;
                @SantaTrapN.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSantaTrapN;
                @SantaTrapN.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSantaTrapN;
                @SantaTrapE.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSantaTrapE;
                @SantaTrapE.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSantaTrapE;
                @SantaTrapE.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSantaTrapE;
                @KrampusAttack2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKrampusAttack2;
                @KrampusAttack2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKrampusAttack2;
                @KrampusAttack2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKrampusAttack2;
                @KrampusAttack3.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKrampusAttack3;
                @KrampusAttack3.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKrampusAttack3;
                @KrampusAttack3.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKrampusAttack3;
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
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @KrampusAttack1.started += instance.OnKrampusAttack1;
                @KrampusAttack1.performed += instance.OnKrampusAttack1;
                @KrampusAttack1.canceled += instance.OnKrampusAttack1;
                @SantaTrapW.started += instance.OnSantaTrapW;
                @SantaTrapW.performed += instance.OnSantaTrapW;
                @SantaTrapW.canceled += instance.OnSantaTrapW;
                @CycleTrapsR.started += instance.OnCycleTrapsR;
                @CycleTrapsR.performed += instance.OnCycleTrapsR;
                @CycleTrapsR.canceled += instance.OnCycleTrapsR;
                @CycleTrapsL.started += instance.OnCycleTrapsL;
                @CycleTrapsL.performed += instance.OnCycleTrapsL;
                @CycleTrapsL.canceled += instance.OnCycleTrapsL;
                @SantaTrapN.started += instance.OnSantaTrapN;
                @SantaTrapN.performed += instance.OnSantaTrapN;
                @SantaTrapN.canceled += instance.OnSantaTrapN;
                @SantaTrapE.started += instance.OnSantaTrapE;
                @SantaTrapE.performed += instance.OnSantaTrapE;
                @SantaTrapE.canceled += instance.OnSantaTrapE;
                @KrampusAttack2.started += instance.OnKrampusAttack2;
                @KrampusAttack2.performed += instance.OnKrampusAttack2;
                @KrampusAttack2.canceled += instance.OnKrampusAttack2;
                @KrampusAttack3.started += instance.OnKrampusAttack3;
                @KrampusAttack3.performed += instance.OnKrampusAttack3;
                @KrampusAttack3.canceled += instance.OnKrampusAttack3;
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
        void OnInteract(InputAction.CallbackContext context);
        void OnKrampusAttack1(InputAction.CallbackContext context);
        void OnSantaTrapW(InputAction.CallbackContext context);
        void OnCycleTrapsR(InputAction.CallbackContext context);
        void OnCycleTrapsL(InputAction.CallbackContext context);
        void OnSantaTrapN(InputAction.CallbackContext context);
        void OnSantaTrapE(InputAction.CallbackContext context);
        void OnKrampusAttack2(InputAction.CallbackContext context);
        void OnKrampusAttack3(InputAction.CallbackContext context);
    }
}
