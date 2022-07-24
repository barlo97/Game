/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoNotesSpawner : MonoBehaviour
{
    #region Variables
    public GameObject[] TwoNotes;
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
        Debug.Log("Klawisz = " + generateKeys);
        Instantiate(TwoNotes[generateKeys % TwoNotes.Length], transform.position, Quaternion.identity);
        generateKeys++;
        
    }


    #endregion
}
