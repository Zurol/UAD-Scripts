using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform target; // Reference to the target object's Transform

    private void Update()
    {
        if (target != null)
        {
            // Calculate the direction from the enemy to the target object
            Vector3 directionToTarget = target.position - transform.position;
            directionToTarget.y = 0f; // Keep the rotation on the horizontal plane

            // Rotate the enemy to face the target object
            transform.rotation = Quaternion.LookRotation(directionToTarget);
        }
    }
}
