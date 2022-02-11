using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    public Rigidbody rigidbody;
    [SerializeField] private CommandContainer _commandContainer;
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private PlayerDash _playerDash;

    private void Update()
    { 
        HandleMovement();
    }

    private void HandleMovement()
    {
        if (_playerDash.stopmovement == false)
        {
           rigidbody.velocity = new Vector3(_commandContainer.walkCommand * moveSpeed, rigidbody.velocity.y, 0);
        }
    }

}
