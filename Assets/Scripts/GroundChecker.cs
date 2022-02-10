using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private float groundCheckDistance = 0.55f;
    [SerializeField] private float sphereCastRadius = 1f;
    public bool isGrounded { get; private set; }
    void Update()
    {
        CheckIfGrounded();
    }

    private void CheckIfGrounded()
    {
        var sphereCast = new Ray(transform.position, Vector3.down);
        isGrounded = Physics.SphereCast(sphereCast, sphereCastRadius, groundCheckDistance);

    }
}
