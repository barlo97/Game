/*
 Copyright (c) Józef Yika
*/


using UnityEngine;

public class Level2_SpawnerStatic : MonoBehaviour
{
    #region Variables
    public GameObject[] Keys;
    private GameObject note;
    public GameObject Note { get { return note; } }

    private float minimumX_Negative;
    private float maximumX_Positive;
    private float _xIncrement;
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        GenerateFirstKey();
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
        var posX = GenericScript.CalculatePositionFromNoteName(Keys[index].name);
        var vector2D = new Vector2(posX, transform.position.y);
        transform.position = vector2D;

        // Instantiate key on corresponding position
        return note = Instantiate(Keys[index], vector2D, Quaternion.identity);       
    }

    public GameObject GenerateNewKey()
    {
        DestroyKey();
        // Generate index for 'key' to instantiate
        var index = Random.Range(0, Keys.Length);
        var posX = GenericScript.CalculatePositionFromNoteName(Keys[index].name);
        var vector2D = new Vector2(posX, transform.position.y);
        transform.position = vector2D;

        // Instantiate key on corresponding position
        return note = Instantiate(Keys[index], vector2D, Quaternion.identity);
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
