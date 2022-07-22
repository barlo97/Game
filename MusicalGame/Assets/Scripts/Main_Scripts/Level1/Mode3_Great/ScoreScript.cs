/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    #region Variables
    public TextMeshProUGUI scoreOnTheScreen;
    private int scoreNumber;
    #endregion

    #region Unity Methods
	
    // Start is called before the first frame update
    void Start()
    {
        scoreNumber = 0;
        scoreOnTheScreen.text =  scoreNumber.ToString();
    }

    public void OnTriggerEnter2D(Collider2D note) // if my key collides with the note ( the note that is coming down from the top) do the code inside
    {
        if (note.tag == "C") // if this key collides with C note add one point 
        {
            scoreNumber = scoreNumber + 1;
            scoreOnTheScreen.text = scoreNumber.ToString();
        }
        else // if it collides with any other note take away one point 
        {
            scoreNumber = scoreNumber - 1;
            scoreOnTheScreen.text = scoreNumber.ToString();
        }
    }
    #endregion
}
