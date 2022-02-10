using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerJump : MonoBehaviour
{

    [SerializeField] private float jumpForce = 400;
    
    public Rigidbody rigidbody;
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private GroundChecker _groundChecker;
    [SerializeField] private CommandContainer _commandContainer;
    private void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {

        if (_commandContainer.jumpCommand && _groundChecker.isGrounded)
        {
            rigidbody.AddForce(0, jumpForce, 0);
        }
        
    }
}
