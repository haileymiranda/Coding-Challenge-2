using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //In these lines of code I am assigning my variables with values
    float horiMovement;
    float vertMovement;
    float speed = 0.88f;
    float jumpHeight = 0.5f;

//This variable was giving me issues so I try to set it to public to fix it
   string RigidBody = playerRB;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<RigidBody>();

    }

    // Update is called once per frame
    void Update()
    {
        // Here I am able to tell the code to get each axis from the Unity Asset Manager
        horiMovement = Input.GetAxis("Horizontal");
        vertMovement = Input.GetAxis("Vertical");


        //This part of my code allows for my capsule to move in sync, horizontally
        transform.Translate(horiMovement* Time.deltaTime * speed,0,0);

        //This part of my code allows for my capsule to move in sync, vertically
        transform.Translate(0 ,0,vertMovement * Time.deltaTime * speed);

        //This part allows my capsule to jump with the space key
       if (Input.GetKeyDown(KeyCode.Space))
        {
            //This allows me to make the capsule jump the height I want
            playerRB.AddForce(jumpHeight);

        }

    }
    


}