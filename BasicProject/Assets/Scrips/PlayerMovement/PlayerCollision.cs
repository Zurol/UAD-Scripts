using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public float knockbackForce = 5f; // The force applied when colliding with an obstacle

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with an obstacle
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Collision");

            // Calculate knockback direction away from the collision
            Vector3 knockbackDirection = transform.position - collision.contacts[0].point;
            knockbackDirection = knockbackDirection.normalized;

            // Apply knockback force to the player
            GetComponent<Rigidbody>().AddForce(knockbackDirection * knockbackForce, ForceMode.Impulse);

            // Play collision sound or animation here
        }
    }
}
