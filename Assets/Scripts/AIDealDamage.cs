using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDealDamage : MonoBehaviour
{
    public bool isHit = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            isHit = true;
            StartCoroutine(InvulnerableTimer());
        }
    }

    IEnumerator InvulnerableTimer()
    {
        yield return new WaitForSeconds(0.3f);
        isHit = false;
    }
}
