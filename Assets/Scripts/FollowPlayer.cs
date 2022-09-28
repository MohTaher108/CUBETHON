using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // Keep track of player's position
    public Transform player;
    // Offset the camera so we're not inside the player
    public Vector3 offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Make the camera's position vector equal to the player's position vector plus the offset vector (adds each set of components individually)
        transform.position = player.position + offset;
    }
}
