/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScriptG : MonoBehaviour
{
    #region Variables
    public TextMeshProUGUI scoreOnTheScreen;

    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        ScoreBoardStatic.ResetPoints();
        scoreOnTheScreen.text = ScoreBoardStatic.ScoreAPoint.ToString();
    }

    public void OnTriggerEnter2D(Collider2D note) // if my key collides with the note ( the note that is coming down from the top) do the code inside
    {
        if (note.tag == "G") // if this key collides with C note add one poissnt 
        {
            ScoreBoardStatic.IncrementPoints();

        }
        else // if it collides with any other note take away one point 
        {
            ScoreBoardStatic.DecrementPoints();

        }
        scoreOnTheScreen.text = ScoreBoardStatic.ScoreAPoint.ToString();
    }
    #endregion
}
