using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerInputListener : MonoBehaviour
{
    private CharacterController2D controller;

    private void Awake() {
        controller = GetComponent<CharacterController2D>();
    }

    public void OnInterract(InputAction.CallbackContext context)
    {
        if (context.performed) {
            Player.Instance.Interract();
        }
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        if (context.performed) {
            float movement = context.ReadValue<float>();
            controller.OnMovement(movement);
        } else if (context.canceled) {
            controller.OnMovement(0f);
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed) {
           controller.OnJump();
        } else if (context.canceled) {
            controller.OnJumpCancel();
        }
    }

    public void OnPause(InputAction.CallbackContext context)
    {
        if (context.performed) {
            PauseMenu.Instance.OnPauseKeyPress();
        }
    }
}
