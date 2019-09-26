using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager gameManager;
    void OnCollisionEnter(Collision collisionInfo){
        // Debug.Log("Hit Ground");

       // Debug.Log(collisionInfo.collider.name);
        if(collisionInfo.collider.tag == "Obstacle"){
            Debug.Log("WE hit an obstacle");

            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
