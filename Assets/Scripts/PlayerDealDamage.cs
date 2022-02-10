using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDealDamage : MonoBehaviour
{

    [SerializeField] private PlayerDash playerDash;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player") && playerDash.isDashing)
        {
            Destroy(gameObject);
        }
    }
}
