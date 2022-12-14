using UnityEngine;

public class StayInBounds : MonoBehaviour
{
    public PolygonCollider2D bounds;

    void Update()
    {
        // Check if the gameobject's position is outside of the bounds of the collider.
        if (!bounds.OverlapPoint(transform.position))
        {
            // If it is, move the gameobject back inside the bounds of the collider.
            transform.position = bounds.ClosestPoint(transform.position);
        }
    }

}