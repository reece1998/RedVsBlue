using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter (Collision cInfo)
    {
        if (cInfo.collider.tag == "Walls"){

            movement.enabled = false;
            FindObjectOfType<Gm>().EndGame();
        }
    }
}
