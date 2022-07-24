/*
 Copyright (c) Józef Yika
*/


using UnityEngine;

public class Level2_SpawnerStatic : MonoBehaviour
{

    #region Variables
    public GameObject[] TwoNotes;
    private Vector2 targetPos;
    public float maximumBorderWidth;
    public float minimumBorderWidth;
    public float XIncrement;
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
        Instantiate(TwoNotes[Random.Range(0, TwoNotes.Length)], transform.position, Quaternion.identity);
    }


    public void MoveSpawnerRight()
    {
        if (transform.position.x + XIncrement < maximumBorderWidth)
        {
            Debug.Log("Go Right");
            targetPos = new Vector2(transform.position.x + XIncrement, transform.position.y);
            transform.position = targetPos;
        }
    }

    public void MoveSpawnerLeft()
    {
        if (transform.position.x - XIncrement > minimumBorderWidth)
        {
            Debug.Log("Go Left");
            targetPos = new Vector2(transform.position.x - XIncrement, transform.position.y);
            transform.position = targetPos;
        }
    }
    #endregion
}
