/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    #region Variables
    //public GameObject note;
    //private float timeBetweenspawn;
    //public float startTimeBetweenspawn;
    //public float decreaseTime;
    //public float minTime = 0.65f;


    public GameObject[] Keys;

    
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        NewKey();
    }

    // Update is called once per frame
    void Update()
    {
        //if(timeBetweenspawn <= 0)
        //{
        //    Instantiate(note, transform.position, Quaternion.identity);
        //    timeBetweenspawn = startTimeBetweenspawn;
        //    if (startTimeBetweenspawn > minTime)
        //    {
        //        startTimeBetweenspawn -= decreaseTime;
        //    }
        //}
        //else
        //{
        //    timeBetweenspawn -= Time.deltaTime;
        //}
    }




    public void NewKey()
    {
        Instantiate(Keys[Random.Range(0, Keys.Length)], transform.position, Quaternion.identity);
       
    }

  
    
    #endregion
}
