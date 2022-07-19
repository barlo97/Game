/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollision : MonoBehaviour
{
    #region Variables


    #endregion

    #region Unity Methods



    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("The square collided with: " + collision.gameObject.name);
    }



    #endregion
}
