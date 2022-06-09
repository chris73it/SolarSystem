using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[Serializable]
public class MoveInputEvent : UnityEvent<Vector2>
{
}

public sealed class InputController : MonoBehaviour
{
    [SerializeField] MoveInputEvent moveInputEvent;

    Controls controls;
    private void Awake()
    {
        controls = new Controls();

        controls.Gameplay.Move.started += OnMove;
        controls.Gameplay.Move.canceled += OnMove;
        controls.Gameplay.Move.performed += OnMove;
    }

    private Vector2 moveInput;
    [HideInInspector] public bool IsMovePressed;
    private void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        Debug.Log($"moveInput {moveInput}");
        IsMovePressed = moveInput != Vector2.zero;
        Debug.Log($"IsMovePressed {IsMovePressed}");
        moveInputEvent.Invoke(moveInput);
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
