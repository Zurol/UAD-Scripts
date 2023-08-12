using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] patrolPoints;   // Array of patrol points
    public float moveSpeed = 3f;       // Enemy movement speed

    private int currentPatrolIndex = 0;
    private Vector3 currentPatrolPoint;

    private void Start()
    {
        if (patrolPoints.Length > 0)
        {
            currentPatrolPoint = patrolPoints[currentPatrolIndex].position;
        }
    }

    private void Update()
    {
        if (patrolPoints.Length == 0)
        {
            return; // No patrol points, do nothing
        }

        // Calculate the direction to the current patrol point
        Vector3 moveDirection = (currentPatrolPoint - transform.position).normalized;

        // Move the enemy towards the patrol point
        MoveTowardsPatrolPoint(moveDirection);

        // Check if the enemy has reached the patrol point
        if (Vector3.Distance(transform.position, currentPatrolPoint) < 0.2f)
        {
            // Switch to the next patrol point
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
            currentPatrolPoint = patrolPoints[currentPatrolIndex].position;
        }
    }

    private void MoveTowardsPatrolPoint(Vector3 direction)
    {
        // Move the enemy
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
}
