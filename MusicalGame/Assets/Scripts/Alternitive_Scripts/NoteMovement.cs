/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMovement : MonoBehaviour
{
    #region Variables

    //private Vector2 targetPos;

    public float movementSpeed = 2f;
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x <10)
        //{
        //    targetPos = new Vector2(transform.position.x + XMovementIncrement, transform.position.y);
        //    transform.position = targetPos;
        //}
        //else if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -32)
        //{
        //    targetPos = new Vector2(transform.position.x - XMovementIncrement, transform.position.y);
        //    transform.position = targetPos;


        //}



        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Time.deltaTime * movementSpeed * Vector3.right;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Time.deltaTime * movementSpeed * Vector3.left;

        }






        #endregion
    }
}