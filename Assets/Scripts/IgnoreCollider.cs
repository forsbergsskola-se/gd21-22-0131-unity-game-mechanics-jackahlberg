using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollider : MonoBehaviour
{

    [SerializeField] private PlayerDash _playerDash;
    [SerializeField] private Collider _collider;
    
    
    private IEnumerator OnCollisionEnter(Collision collision)
    {
        var other = collision.collider;

        if (_playerDash.isDashing && other.CompareTag("Player"))
        {
                Debug.Log("Enemy collided with player");
                Physics.IgnoreCollision(other, _collider, true);
                yield return new WaitForSeconds(1f);
                Debug.Log("Timer Passed");
                Physics.IgnoreCollision(other, _collider, false);
        }

    }


}
