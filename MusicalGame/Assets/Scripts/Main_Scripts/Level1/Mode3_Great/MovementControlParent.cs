/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControlParent : MonoBehaviour
{
    #region Variables


    private Vector2 targetPos;
    public float XIncrement;

    public float velocity;
    public float speed;

    public float maximumBorderHeight;
    public float minimumBorderHeight;

    private float previousTime;
    public float fallTime = 0.8f;

    public float respawnTime = 4.0f;

    private GameObject _note;
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  transform.position = Vector2.MoveTowards(transform.position, targetPos, velocity * Time.deltaTime);


        transform.Translate(Vector2.down * speed * Time.deltaTime);



        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maximumBorderHeight)
        {
            targetPos = new Vector2(transform.position.x + XIncrement, transform.position.y);
            transform.position = targetPos;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minimumBorderHeight)
        {
            targetPos = new Vector2(transform.position.x - XIncrement, transform.position.y);
            transform.position = targetPos;
        }




    }

    void OnTriggerEnter2D(Collider2D pianoKey)
    {

        if (pianoKey.CompareTag("C") || pianoKey.CompareTag("CSharp") || pianoKey.CompareTag("D") || pianoKey.CompareTag("DSharp") || pianoKey.CompareTag("E") || pianoKey.CompareTag("F") || pianoKey.CompareTag("FSharp") || pianoKey.CompareTag("G") || pianoKey.CompareTag("GSharp") || pianoKey.CompareTag("A") || pianoKey.CompareTag("ASharp") || pianoKey.CompareTag("B"))
        {

            _note = GameObject.FindObjectOfType<SpawnerParent>().Note;
            if(_note != null)
            {

                Destroy(_note);
               
            }
            
        }

  
    }

    


    #endregion
}
