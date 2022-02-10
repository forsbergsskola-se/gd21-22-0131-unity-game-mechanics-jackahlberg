using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollowPlayer : MonoBehaviour
{
        [SerializeField] private CommandContainer _commandContainer;
        [SerializeField] private Transform playerTransform;
        [SerializeField] private Rigidbody AIrigidbody;
        [SerializeField] private GroundChecker _groundChecker;
        public Single horizontalDirection { get; private set; }
        public float triggerJump = 1f;
        public float jumpForce = 100f;

        private void Update()
        {
                HandleFollow();
        }

        private void HandleFollow()
        {
                var directionToPlayer = playerTransform.position - transform.position;
                directionToPlayer.Normalize();
                horizontalDirection = directionToPlayer.x;
                var yAxisAI = transform.position.y;
                var yAxisPlayer = playerTransform.position.y - 0.2f;
                var distance = Vector2.Distance(playerTransform.position, this.transform.position);

                if(distance <= 15)
                {
                    _commandContainer.walkCommand = horizontalDirection;

                }


                if (yAxisPlayer > yAxisAI && _groundChecker.isGrounded && distance <= triggerJump)
                {
                    AIrigidbody.AddForce(0, jumpForce, 0);
                }
        }
        
}
