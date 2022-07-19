/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerE_F : MonoBehaviour
{
    #region Variables
    public GameObject[] KeysE_F;
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        NewKeysE_F();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void NewKeysE_F()
    {
        Instantiate(KeysE_F[Random.Range(0, KeysE_F.Length)], transform.position, Quaternion.identity);
    }

    #endregion
}