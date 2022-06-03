/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    #region Variables

    /* takes position, rotation, and scale of an object , in this case this will be our cube. Our camera will have the 
       position, scale and rotation of our object. */
    public Transform cube; 
    public float smoothSpeed = 10f;
    public Vector3 offset; // Vector3 is used to determine X, Y,Z coordinates of the object




    #endregion

    #region Unity Methods
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*LateUpdate is called after all Update functions have been called. This is useful to 
      order script execution. For example a follow camera should always be implemeneted in here
      because it tracks objects that might have moved inside Update. All of the code inside the Update method 
      will be executed before the LateUpdate is called. By the time LateUpdate is called
      our cube has already moved. */
    private void FixedUpdate()
    {
        Vector3 targetPosition = cube.position + offset; // the position of the cube + offset

        /*Linear Interpolation - Lerp - process of smoothly going from point A to B.
          the last parameter for Lerp - t is just any value between 0 and 1. If its 0 than its going to give us 
          the first position (transform.position) and if its one its going to give us second position (targetPosition). If its in between 0 and 1
          it is going to give us a mix of those two positions. I am multiplying by delta tiime so that the smoothness occurs at the same speed 
          no matter the frame rate.*/
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed*Time.deltaTime);
        
        /*assign the position of the cube to the position of the camera 
          track the position of my cube*/                   
        transform.position = smoothPosition;

        transform.LookAt(cube); // make the camera look at the cube all the time
    }



    #endregion
}
