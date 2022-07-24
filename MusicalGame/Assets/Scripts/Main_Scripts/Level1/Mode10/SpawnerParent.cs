/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerParent : MonoBehaviour
{
    #region Variables
    public GameObject[] Keys;
    public static int generateKeys;

    private GameObject _note;
    public GameObject Note { get { return _note; } }

    
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        _note = NewKeys();

    }

    // Update is called once per frame
    void Update()
    {
        if(_note == null)
        {
            _note = NewKeys();
        }
        
    }


    public GameObject NewKeys()
    {
     // Debug.Log($"Nuta = {generateKeys} zostala wygenerowana");
        return Instantiate(Keys[generateKeys++ % Keys.Length], transform.position, Quaternion.identity);


    }


    #endregion
}
