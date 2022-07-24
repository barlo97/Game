/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2_SpawnerNonStatic : MonoBehaviour
{
    #region Variables
    public GameObject[] Keys;
    private GameObject note;
    public GameObject Kostka { get => note; }

    private float minimumX_Negative;
    private float maximumX_Positive;
    private float _xIncrement;
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        GenerateFirstKey();
        // Initialize new key on a board     
    }

    // Update is called once per frame
    void Update()
    {
        // Keep the key to always 'alive'
        if (note == null)
        {
            note = GenerateNewKey();
        }
    }

    public GameObject GenerateFirstKey()
    {
        var index = Random.Range(0, Keys.Length);

        // Instantiate key on corresponding position
        note = Instantiate(Keys[index], transform.position, Quaternion.identity);
        minimumX_Negative = FindObjectOfType<Level2_MovementControlNonStatic>().minimumX_Negative;
        maximumX_Positive = FindObjectOfType<Level2_MovementControlNonStatic>().maximumX_Positive;
        _xIncrement = FindObjectOfType<Level2_MovementControlNonStatic>().XIncrement;

        // Copy position of this "Level2_Spawner"
        var position = transform.position;

        // Calculate position 'x' for new instance of key.        
        position.x = minimumX_Negative + index * _xIncrement;
        transform.position = position;
        note.transform.position = position;
        return note;
    }

    public GameObject GenerateNewKey()
    {
        DestroyKey();
        // Generate index for 'key' to instantiate
        var index = Random.Range(0, Keys.Length);

        // Copy position of this "Level2_Spawner"
        var position = transform.position;

        // Calculate position 'x' for new instance of key.        
        position.x = minimumX_Negative + index * _xIncrement;


        // Instantiate key on corresponding position
        transform.position = position;
        return note = Instantiate(Keys[index], position, Quaternion.identity);
    }

    public GameObject ReplaceExistingKey(int index, Vector3 position)
    {
        // Destroy existing key
        DestroyKey();

        // Check if given index is valid
        if (index < 0 || index >= Keys.Length)
        {
            index = 0;
        }

        // Instantiate specific key on a given position
        var targetPos = new Vector2(position.x, transform.position.y);
        transform.position = targetPos;

        Debug.Log("Note : " + Keys[index].name);

        return note = Instantiate(Keys[index], position, Quaternion.identity);
    }

    public void DestroyKey()
    {
        // Check if key is already destroyed 
        // If so: do nothing, if not: destroy it
        if (note == null)
        {
            return;
        }
        Destroy(note);
    }

    #endregion
}
