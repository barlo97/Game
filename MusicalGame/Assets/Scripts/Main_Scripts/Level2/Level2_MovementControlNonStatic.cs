/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2_MovementControlNonStatic : MonoBehaviour
{
    #region Variables


    private Vector2 targetPos;
    public float XIncrement;

    public float velocity;
    public float speed;

    public float maximumX_Positive;
    public float minimumX_Negative;

    public float fallTime = 0.8f;

    public float respawnTime = 4.0f;

    private Level2_SpawnerNonStatic _spawner;
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        _spawner = FindObjectOfType<Level2_SpawnerNonStatic>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        var moved = false;

        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maximumX_Positive)
        {
            targetPos = new Vector2(transform.position.x + XIncrement, transform.position.y);
            transform.position = targetPos;
            moved = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minimumX_Negative)
        {
            targetPos = new Vector2(transform.position.x - XIncrement, transform.position.y);
            transform.position = targetPos;
            moved = true;
        }

        // If key has been moved in current frame:
        //      Calculate index from position.
        //      Destroy current key
        //      Generate new key based on calculated index

        if (moved)
        {
            var index = (int)((transform.position.x - minimumX_Negative) / XIncrement);
            _spawner.DestroyKey();
            _spawner.ReplaceExistingKey(index, transform.position);
        }
    }

    void OnTriggerEnter2D(Collider2D pianoKey)
    {

        if (pianoKey.CompareTagsExtension())
        {
            Debug.Log("COLLISION + " + pianoKey.name);

            _spawner.DestroyKey();
        }
    }
    #endregion
}
