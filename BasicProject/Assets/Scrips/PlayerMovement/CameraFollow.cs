using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;         // The target to follow (player's Transform)
    public float smoothSpeed = 0.125f; // The smoothness of the camera's movement

    public Vector3 offset;           // The offset from the target's position

    public Vector2 minBounds;        // Minimum camera bounds
    public Vector2 maxBounds;        // Maximum camera bounds

    private void LateUpdate()
    {
        // Calculate the desired camera position
        Vector3 desiredPosition = target.position + offset;

        // Apply camera boundary limits
        desiredPosition.x = Mathf.Clamp(desiredPosition.x, minBounds.x, maxBounds.x);
        desiredPosition.y = Mathf.Clamp(desiredPosition.y, minBounds.y, maxBounds.y);

        // Smoothly move the camera towards the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Set the camera's position to the smoothed position
        transform.position = smoothedPosition;
    }
}
