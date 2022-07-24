/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    #region Variables
    public GameObject[] Keys;
    public static int generateKeys;
    #endregion

    #region Unity Methods
	
    // Start is called before the first frame update
    void Start()
    {
        NewKeys();
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void NewKeys() 
    {
        Debug.Log($"Note = {generateKeys} has been generated"); 
        Instantiate(Keys[generateKeys++ % Keys.Length], transform.position, Quaternion.identity);
        
        
    }


    #endregion
}
