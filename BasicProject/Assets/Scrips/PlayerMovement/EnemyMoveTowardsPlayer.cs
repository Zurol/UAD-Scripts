using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveTowardsPlayer : MonoBehaviour
{
    public Transform player;         // Reference to the player's Transform
    public float moveSpeed = 3f;     // Enemy movement speed

    private void Update()
    {
        if (player == null)
        {
            return; // No player reference, do nothing
        }

        // Calculate the direction from the enemy to the player
        Vector3 moveDirection = (player.position - transform.position).normalized;

        // Move the enemy towards the player
        MoveTowardsPlayer(moveDirection);
    }

    private void MoveTowardsPlayer(Vector3 direction)
    {
        // Move the enemy
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
}
