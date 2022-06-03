using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyMovement : MonoBehaviour
{

    public Rigidbody rb; // this creates a new slot within the script in Unity with this value
                         // We can then drag our actual Rigidbody inside Unity to this new slot 
                         // So whenever we use this variable rb , this will refer to the Rigidbody that we dragged to the slot

    public float forwardForce = 2000f; // this will be displayed in Unity. It determines the force with which the cube is moving
    public float sideForce = 500f; // displayed in Unity - determines the force at which the cube moves right and left 


    /*Start is called before the first frame update. 
      This method is called at the start of the game - hence the name*/
    void Start()
    {

        
        Debug.Log("Hello there lad! Want to learn the piano? Let's do this!");
        //rb.useGravity = false;  // get rid of gravity 
        
    }

    /* Update is called once per frame
     A computer draws an image multiple times a second 
     If this method is called once per frame this means that it will run slower
     on the slower computer and faster on the faster computer. A frame is a single, still image 
     displayed by a computer that is generated a certain amount of time per second 
     depending on how good our computer is. One computer may generate more frames per second
     than the other - that is why this Update method if called once per frame will depend 
     on how good our computer is. Better PC means more FPS - meaning less time between frames. 
     For example If a computer runs at 100 FPS this Update is called 100 times. 
    */












    /*
     FixedUpdate Update runs once per frame. FixedUpdate can run once, zero, or several times 
     per frame, depending on how many physics frames per second are set in the time settings, 
     and how fast/slow the framerate is.FixedUpdate is used for being in-step with the physics engine, 
     so anything that needs to be applied to a rigidbody should happen in FixedUpdate
     */
    void FixedUpdate()
    {
        /* apply constant force to this rigidbody so that it moves forward
         Time.delta time is the completion of seconds since the last frame.
         Using a variable forwardForce that is displayed in Unity inside the script section of the Cube, 
         because this script was applied to Cube. 
         */
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);          

        // If a user pressed a right arrow on the keyboard else if the user pressed the left arrow 
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // adding force on x axis - so to the right 
            rb.AddForce(sideForce, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            // adding force on -x axis - so to the left 
            rb.AddForce(-sideForce, 0, 0);
        }
    }


}
