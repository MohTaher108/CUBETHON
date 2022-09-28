using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Keep track of the player
    public PlayerMovement movement;
    // Figure out when we collide with something
    void OnCollisionEnter(Collision collisionInfo) 
    {
        // If we collide with an obstacle
        if(collisionInfo.collider.tag == "Obstacle") 
        {
            // Disallow player movement and end the game
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
