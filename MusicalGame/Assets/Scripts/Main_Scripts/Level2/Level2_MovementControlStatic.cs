/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2_MovementControlStatic : MonoBehaviour
{
    #region Variables


    private Vector2 targetPos;
    public float XIncrement;

    public float velocity;
    public float speed;

    public float maximumX_Positive;
    public float minimumX_Negative;

    private float previousTime;
    public float fallTime = 0.8f;

    public float respawnTime = 4.0f;

    private Level2_SpawnerStatic _spawner;
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        _spawner = FindObjectOfType<Level2_SpawnerStatic>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D pianoKey)
    {
        if (pianoKey.CompareTagsExtension())
        {          
            _spawner.DestroyKey();
        }
    }
    #endregion
}



