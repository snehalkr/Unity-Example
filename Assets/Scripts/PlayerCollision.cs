using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerScript playerMovement; 

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "ObstacleTag")
        {
            Debug.Log("Collision Occured: " + collision.collider.name);
            playerMovement.enabled = false;
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
}
