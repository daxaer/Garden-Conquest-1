// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""12e19ddd-2952-44d2-bad7-57f7795cbfdc"",
            ""actions"": [
                {
                    ""name"": ""Axis"",
                    ""type"": ""Button"",
                    ""id"": ""09ab18e1-b267-45a6-9812-4a1fce4557c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8c98d9b9-3252-4cdf-9844-fa8158947f22"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Derecha"",
                    ""type"": ""Button"",
                    ""id"": ""c2ef3599-bb43-4e33-b24b-f333c8a38bea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Izquierda"",
                    ""type"": ""Button"",
                    ""id"": ""99940e70-f5c0-43bd-929f-94df324de399"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PasarTurno"",
                    ""type"": ""Button"",
                    ""id"": ""31174e60-12af-460b-b4ae-3bdd89cab348"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Lanzarbjeto"",
                    ""type"": ""Button"",
                    ""id"": ""98ac8593-9721-49e7-ab4b-eb1edb692167"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""26494704-0fb0-4f7b-bce6-8fc1d0d6d22c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e27a0250-4b57-40d4-8579-e3f26da5da28"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d8a672ab-cc7a-4b7b-9be4-2252bde17cde"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""5b7ad1f1-7255-43b8-bc7d-b4f055bd36f0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""963117dc-3ec6-4b32-b9b0-1ba06a296355"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""83ecef46-85d3-41f9-9db4-fa16d13865f9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0462ec10-b28c-4fa6-85dc-aaafcf6c7943"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""683a2739-423d-446d-b754-2e7528962fc7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Derecha"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""525d6a87-53f0-4fdd-a2d1-b07ed1f29881"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Izquierda"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbed2957-781f-4781-add9-10670399d06e"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PasarTurno"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2df97006-ad6b-4020-b192-1a7100b481ac"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lanzarbjeto"",
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
        m_Gameplay_Axis = m_Gameplay.FindAction("Axis", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_Derecha = m_Gameplay.FindAction("Derecha", throwIfNotFound: true);
        m_Gameplay_Izquierda = m_Gameplay.FindAction("Izquierda", throwIfNotFound: true);
        m_Gameplay_PasarTurno = m_Gameplay.FindAction("PasarTurno", throwIfNotFound: true);
        m_Gameplay_Lanzarbjeto = m_Gameplay.FindAction("Lanzarbjeto", throwIfNotFound: true);
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
    private readonly InputAction m_Gameplay_Axis;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_Derecha;
    private readonly InputAction m_Gameplay_Izquierda;
    private readonly InputAction m_Gameplay_PasarTurno;
    private readonly InputAction m_Gameplay_Lanzarbjeto;
    public struct GameplayActions
    {
        private @InputController m_Wrapper;
        public GameplayActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Axis => m_Wrapper.m_Gameplay_Axis;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @Derecha => m_Wrapper.m_Gameplay_Derecha;
        public InputAction @Izquierda => m_Wrapper.m_Gameplay_Izquierda;
        public InputAction @PasarTurno => m_Wrapper.m_Gameplay_PasarTurno;
        public InputAction @Lanzarbjeto => m_Wrapper.m_Gameplay_Lanzarbjeto;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Axis.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAxis;
                @Axis.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAxis;
                @Axis.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAxis;
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Derecha.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDerecha;
                @Derecha.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDerecha;
                @Derecha.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDerecha;
                @Izquierda.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnIzquierda;
                @Izquierda.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnIzquierda;
                @Izquierda.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnIzquierda;
                @PasarTurno.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPasarTurno;
                @PasarTurno.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPasarTurno;
                @PasarTurno.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPasarTurno;
                @Lanzarbjeto.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLanzarbjeto;
                @Lanzarbjeto.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLanzarbjeto;
                @Lanzarbjeto.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLanzarbjeto;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Axis.started += instance.OnAxis;
                @Axis.performed += instance.OnAxis;
                @Axis.canceled += instance.OnAxis;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Derecha.started += instance.OnDerecha;
                @Derecha.performed += instance.OnDerecha;
                @Derecha.canceled += instance.OnDerecha;
                @Izquierda.started += instance.OnIzquierda;
                @Izquierda.performed += instance.OnIzquierda;
                @Izquierda.canceled += instance.OnIzquierda;
                @PasarTurno.started += instance.OnPasarTurno;
                @PasarTurno.performed += instance.OnPasarTurno;
                @PasarTurno.canceled += instance.OnPasarTurno;
                @Lanzarbjeto.started += instance.OnLanzarbjeto;
                @Lanzarbjeto.performed += instance.OnLanzarbjeto;
                @Lanzarbjeto.canceled += instance.OnLanzarbjeto;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnAxis(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDerecha(InputAction.CallbackContext context);
        void OnIzquierda(InputAction.CallbackContext context);
        void OnPasarTurno(InputAction.CallbackContext context);
        void OnLanzarbjeto(InputAction.CallbackContext context);
    }
}
