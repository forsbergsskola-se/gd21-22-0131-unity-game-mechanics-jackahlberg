using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    [SerializeField] public float dashForce;
    public float dashRightForce;
    public float dashLeftForce;
    public int dashDirection;
    public bool isDashing;
    public bool stopmovement;
    public Rigidbody _rigidbody;
    [SerializeField] private CommandContainer _commandContainer;

    private void Start()
    {
        dashDirection = 0;
        dashForce = 30;
        dashRightForce = dashForce;
        dashLeftForce = dashForce * -1;
        stopmovement = false;
    }

    void Update()
    {
        HandleDash();
        CheckDashDirection();
    }

    private void HandleDash()
    {

        // Dashes to the right.
        if (_commandContainer.dashCommand && dashDirection == 1 && isDashing == false)
        {
            isDashing = true;
            stopmovement = true;
            _rigidbody.velocity = new Vector3(dashRightForce, 0, 0);
            StartCoroutine(DashTimer());
            StartCoroutine(StopMovement());
;        }
        //Dashes to the left.
        else if (_commandContainer.dashCommand && dashDirection == 0 && isDashing == false)
        {
            isDashing = true;
            stopmovement = true;
            _rigidbody.velocity = new Vector3(dashLeftForce, 0, 0);
            StartCoroutine(DashTimer());
            StartCoroutine(StopMovement());
        }
    }

    IEnumerator DashTimer()
    {
        yield return new WaitForSeconds(1f);
        isDashing = false;
    }

    IEnumerator StopMovement()
    {
        yield return new WaitForSeconds(0.3f);
        stopmovement = false;
    }

    private void CheckDashDirection()
    {
        if (_commandContainer.dashRightCommand)
        {
            dashDirection = 1;
        }
        else if (_commandContainer.dashLeftCommand)
        {
            dashDirection = 0;
        }

    }
}
