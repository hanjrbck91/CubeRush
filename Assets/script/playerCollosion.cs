using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollosion : MonoBehaviour
{
    public playerScript movement;
    

    //This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".

  void OnCollisionEnter(Collision collisionInfo)
    {
        //We check if the object we collided with has a tag called "Obstacle".
        if(collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            //Disable the players movement.
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
