/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Level2_SpawnerNonStatic : MonoBehaviour
{
    #region Variables
    public GameObject[] Keys;
    private GameObject note;   
    public GameObject Note { get => note; }

    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        GenerateFirstNote();
        // Initialize new note on a board     
    }

    // Update is called once per frame
    void Update()
    {    
    }

    public GameObject GenerateFirstNote()
    {
        var index = UnityEngine.Random.Range(0, Keys.Length);
        var posX = GenericScript.CalculatePositionFromNoteName(Keys[index].name);
        var vector2D = new Vector2(posX, transform.position.y);
        transform.position = vector2D;

        // Instantiate key on corresponding position
        return note = Instantiate(Keys[index], transform.position, Quaternion.identity);             
    }

    public GameObject GenerateNewNote()
    {
        DestroyNote();
        // Generate index for 'key' to instantiate
        var index = UnityEngine.Random.Range(0, Keys.Length);
        var posX = GenericScript.CalculatePositionFromNoteName(Keys[index].name);
        var vector2D = new Vector2(posX, transform.position.y);
        transform.position = vector2D;
      
        note = Instantiate(Keys[index], vector2D, Quaternion.identity);
        SynchronizeNotes();
        return note;
    }

    public GameObject ReplaceExistingNote(string noteName, Vector2 position)
    {
        // Destroy existing key
        DestroyNote();
        var tempNote = Keys.FirstOrDefault(x => x.name == noteName);      
        if(tempNote == null)
        {
            tempNote = Keys[0];
        }

        // Instantiate specific key on a given position
        var targetPos = new Vector2(position.x, transform.position.y);
        transform.position = targetPos;
        note = Instantiate(tempNote, position, Quaternion.identity);
        SynchronizeNotes();
        return note;
    }

    public void DestroyNote()
    {
        // Check if key is already destroyed 
        // If so: do nothing, if not: destroy it
        if (note == null)
        {
            return;
        }    
        Destroy(note);
        note = null;
    }

    void SynchronizeNotes()
    {
        var staticSpawner = FindObjectOfType(typeof(Level2_SpawnerStatic));
        //var nonStaticNote = FindObjectOfType<Level2_MovementControlNonStatic>().gameObject;
        if (staticSpawner == null)
        {
            Debug.Log(" nonStaticNote == null");
        }

        if (note == null)
        {
            Debug.Log(" note == null");
        }

        if (staticSpawner == null || note == null)
        {
            return;
        }
        var staticNote = ((Level2_SpawnerStatic)staticSpawner).Note;
        if (staticNote == null)
        {
            return;
        }

        var diff = Mathf.Abs(staticNote.transform.position.y - note.transform.position.y);

        if ( diff > (float)0.01 && diff < 5)
        {
            Debug.Log("------------BEFORE------------}");
            Debug.Log($"nonstatic y: {staticNote.transform.position.y}\n\t         static   y: {note.transform.position.y}");
            Debug.Log("------------BEFORE------------}");

            

            if (staticNote.transform.position.y > note.transform.position.y)
            {
                Debug.Log($"{note.name}  wyzej niz {staticNote.name}. Przesuwanie {staticNote.name} w gore");
                var newPost = new Vector2(note.transform.position.x, staticNote.transform.position.y);
                note.transform.position = newPost;
            }
            else
            {
                Debug.Log($"{staticNote.name}  wyzej niz {note.name}. Przesuwanie {note.name} w gore");
                var newPost = new Vector2(staticNote.transform.position.x, note.transform.position.y);
                staticNote.transform.position = newPost;
            }

            Debug.Log("------------AFTER------------}");
            Debug.Log($"nonstatic y: {staticNote.transform.position.y}\n\t         static   y: {note.transform.position.y}");
            Debug.Log("------------AFTER------------}");
        }
    }

    #endregion
}
