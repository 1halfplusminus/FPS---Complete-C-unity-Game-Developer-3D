//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.1.1
//     from Assets/Inputs/GameInput.inputactions
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

public partial class @GameInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""07b2cea0-0811-4a38-9b54-41ece9dac73f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""2ab213c8-1ab0-42fd-8594-552663eae3dd"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""122ef2ea-d412-41fd-8922-e8b79858f2fb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jumping"",
                    ""type"": ""Button"",
                    ""id"": ""b7354db0-dded-4d8f-a678-b8271e455bdb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Firing"",
                    ""type"": ""Button"",
                    ""id"": ""8a4500d4-a720-4dc0-91eb-19060c340a98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Zooming"",
                    ""type"": ""Value"",
                    ""id"": ""a705d898-ce58-49c9-be86-fbb506398da2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Change Weapon"",
                    ""type"": ""Value"",
                    ""id"": ""0b193ee3-d205-439a-9f31-e3140f317728"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""eff012d2-eb43-4bc7-9f2e-e81732881633"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5eaab9ea-b8ea-41bf-bd5c-f601c5ef4465"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""67442fdc-73bc-461b-8e0c-d6f6e8a6ba6a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bbaf9df6-41ef-439e-9fbe-fc4cdaf376d5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""221c642f-e6b9-48b6-9752-6dbf618a7217"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""1bb0c20b-ec03-4fb5-ae3f-6f41c16ae0e7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""c3f56d00-f5ee-4aeb-b717-dbf8818d2b5c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6ce9e68f-a37a-4f84-a978-3de2b87108c8"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=1.5,y=1.5)"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0471f064-9cf3-44ba-82e2-8a68d0afba7c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b25fddef-db70-4cab-a2a0-17b60270c2d6"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Firing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20412083-8c86-4e96-a7f5-d4a95cd4e7d5"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zooming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""947db68f-b0b4-4003-9f15-b4d897a6bb39"",
                    ""path"": ""<Mouse>/scroll/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Weapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c25fb6c-82bf-4be4-b600-08eca9fdbcff"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Weapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""310b39ba-4b8d-4ef5-b421-d4af0154e1bb"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Weapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Debug"",
            ""id"": ""34482201-b319-4bbc-8289-6b89536fb3f1"",
            ""actions"": [
                {
                    ""name"": ""Hide Cursor"",
                    ""type"": ""Button"",
                    ""id"": ""b65671fa-0367-4b00-a640-6ded070d6631"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f4b494b1-c0e3-468e-8f46-5d760f62b07e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hide Cursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Game"",
            ""id"": ""012a0956-01e1-4d7b-bbc3-361e8c46e48d"",
            ""actions"": [
                {
                    ""name"": ""Exit Game"",
                    ""type"": ""Button"",
                    ""id"": ""35aff7df-0168-4d36-80fd-815eb256e521"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b51f1f40-e267-4cb1-899a-6e3dac2b0c90"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit Game"",
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
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Look = m_Gameplay.FindAction("Look", throwIfNotFound: true);
        m_Gameplay_Jumping = m_Gameplay.FindAction("Jumping", throwIfNotFound: true);
        m_Gameplay_Firing = m_Gameplay.FindAction("Firing", throwIfNotFound: true);
        m_Gameplay_Zooming = m_Gameplay.FindAction("Zooming", throwIfNotFound: true);
        m_Gameplay_ChangeWeapon = m_Gameplay.FindAction("Change Weapon", throwIfNotFound: true);
        // Debug
        m_Debug = asset.FindActionMap("Debug", throwIfNotFound: true);
        m_Debug_HideCursor = m_Debug.FindAction("Hide Cursor", throwIfNotFound: true);
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_ExitGame = m_Game.FindAction("Exit Game", throwIfNotFound: true);
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
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Look;
    private readonly InputAction m_Gameplay_Jumping;
    private readonly InputAction m_Gameplay_Firing;
    private readonly InputAction m_Gameplay_Zooming;
    private readonly InputAction m_Gameplay_ChangeWeapon;
    public struct GameplayActions
    {
        private @GameInput m_Wrapper;
        public GameplayActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Look => m_Wrapper.m_Gameplay_Look;
        public InputAction @Jumping => m_Wrapper.m_Gameplay_Jumping;
        public InputAction @Firing => m_Wrapper.m_Gameplay_Firing;
        public InputAction @Zooming => m_Wrapper.m_Gameplay_Zooming;
        public InputAction @ChangeWeapon => m_Wrapper.m_Gameplay_ChangeWeapon;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Jumping.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJumping;
                @Jumping.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJumping;
                @Jumping.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJumping;
                @Firing.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFiring;
                @Firing.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFiring;
                @Firing.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFiring;
                @Zooming.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZooming;
                @Zooming.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZooming;
                @Zooming.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnZooming;
                @ChangeWeapon.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChangeWeapon;
                @ChangeWeapon.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChangeWeapon;
                @ChangeWeapon.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChangeWeapon;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jumping.started += instance.OnJumping;
                @Jumping.performed += instance.OnJumping;
                @Jumping.canceled += instance.OnJumping;
                @Firing.started += instance.OnFiring;
                @Firing.performed += instance.OnFiring;
                @Firing.canceled += instance.OnFiring;
                @Zooming.started += instance.OnZooming;
                @Zooming.performed += instance.OnZooming;
                @Zooming.canceled += instance.OnZooming;
                @ChangeWeapon.started += instance.OnChangeWeapon;
                @ChangeWeapon.performed += instance.OnChangeWeapon;
                @ChangeWeapon.canceled += instance.OnChangeWeapon;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Debug
    private readonly InputActionMap m_Debug;
    private IDebugActions m_DebugActionsCallbackInterface;
    private readonly InputAction m_Debug_HideCursor;
    public struct DebugActions
    {
        private @GameInput m_Wrapper;
        public DebugActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @HideCursor => m_Wrapper.m_Debug_HideCursor;
        public InputActionMap Get() { return m_Wrapper.m_Debug; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugActions set) { return set.Get(); }
        public void SetCallbacks(IDebugActions instance)
        {
            if (m_Wrapper.m_DebugActionsCallbackInterface != null)
            {
                @HideCursor.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnHideCursor;
                @HideCursor.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnHideCursor;
                @HideCursor.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnHideCursor;
            }
            m_Wrapper.m_DebugActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HideCursor.started += instance.OnHideCursor;
                @HideCursor.performed += instance.OnHideCursor;
                @HideCursor.canceled += instance.OnHideCursor;
            }
        }
    }
    public DebugActions @Debug => new DebugActions(this);

    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_ExitGame;
    public struct GameActions
    {
        private @GameInput m_Wrapper;
        public GameActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ExitGame => m_Wrapper.m_Game_ExitGame;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                @ExitGame.started -= m_Wrapper.m_GameActionsCallbackInterface.OnExitGame;
                @ExitGame.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnExitGame;
                @ExitGame.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnExitGame;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ExitGame.started += instance.OnExitGame;
                @ExitGame.performed += instance.OnExitGame;
                @ExitGame.canceled += instance.OnExitGame;
            }
        }
    }
    public GameActions @Game => new GameActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJumping(InputAction.CallbackContext context);
        void OnFiring(InputAction.CallbackContext context);
        void OnZooming(InputAction.CallbackContext context);
        void OnChangeWeapon(InputAction.CallbackContext context);
    }
    public interface IDebugActions
    {
        void OnHideCursor(InputAction.CallbackContext context);
    }
    public interface IGameActions
    {
        void OnExitGame(InputAction.CallbackContext context);
    }
}
