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
	
   

     void OnTriggerEnter2D(Collider2D pianoKey)
    {
        if (pianoKey.CompareTag("KeyOnThePiano"))
        {
            Destroy(gameObject);
        }
    }


    #endregion
}
