/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
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

    private Spawner spawner;
    #endregion

    #region Unity Methods
	
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(keyWave());
    }

    // Update is called once per frame
    void Update()
    {
        //  transform.position = Vector2.MoveTowards(transform.position, targetPos, velocity * Time.deltaTime);


        transform.Translate(Vector2.down * speed * Time.deltaTime);
        


        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maximumX_Positive)
        {
            targetPos = new Vector2(transform.position.x + XIncrement, transform.position.y);
            transform.position = targetPos;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minimumX_Negative)
        {
            targetPos = new Vector2(transform.position.x - XIncrement, transform.position.y);
            transform.position = targetPos;
        }



        
    }

    void OnTriggerEnter2D(Collider2D pianoKey)
    {

        if (pianoKey.CompareTagsExtension())
        {
            
            Destroy(gameObject);
            Debug.Log("The note is destroyed!");
        }

      

        

    }


    IEnumerator keyWave()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(respawnTime);
            FindObjectOfType<Spawner>().NewKeys();
        }
    }

  


    #endregion
}

// Class Extension For Checking Whether the Note hit the appropropriate key on the piano
public static class Extensions
{
    public static bool CompareTagsExtension(this Collider2D pianoKey)
    {
        return pianoKey.CompareTag("C") || pianoKey.CompareTag("CSharp")
            || pianoKey.CompareTag("D") || pianoKey.CompareTag("DSharp")
            || pianoKey.CompareTag("E") || pianoKey.CompareTag("F")
            || pianoKey.CompareTag("FSharp") || pianoKey.CompareTag("G")
            || pianoKey.CompareTag("GSharp") || pianoKey.CompareTag("A")
            || pianoKey.CompareTag("ASharp") || pianoKey.CompareTag("B");
    }
}
