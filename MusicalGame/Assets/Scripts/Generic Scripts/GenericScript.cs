using UnityEngine;

/// <summary>
/// Class GenericScript contains general scripts used in many levels
/// </summary>
public static class GenericScript
{
    /// <summary>
    /// Method returns note position based on GameObject name
    /// i.e. for 'C' key returns position -9, 
    /// for 'A#' returns 11 etc.
    /// </summary>
    /// <param name="gObject"></param>
    /// <returns></returns>
    public static float CalculatePositionFromNoteName(string noteName)
    {
        return noteName switch
        {
            "C" => -9,
            "C#" => -7,
            "Db" => -7,
            "D" => -5,
            "D#" => -3,
            "Eb" => -3,
            "E" => -1,
            "F" => 1,
            "F#" => 3,
            "Gb" => 3,
            "G" => 5,
            "G#" => 7,
            "Ab" => 7,
            "A" => 9,
            "A#" => 11,
            "Bb" => 11,
            "B" => 13,
            _ => -9
        };
    }

    public static string CalculateNoteNameFromPosition(float position, string type = "Sharp")
    {
        switch(type)
        {
            case "Sharp":
                return position switch
                {
                    -9 => "C",
                    -7 => "C#",
                    -5 => "D",
                    -3 => "D#",
                    -1 => "E",
                    1 => "F",
                    3 => "F#",
                    5 => "G",
                    7 => "G#",
                    9 => "A",
                    11 => "A#",
                    13 => "B",
                    _ => "C"
                };

            case "Flat":
                return position switch
                {
                    -9 => "C",
                    -7 => "Db",
                    -5 => "D",
                    -3 => "Eb",
                    -1 => "E",
                    1 => "F",
                    3 => "Gb",
                    5 => "G",
                    7 => "Ab",
                    9 => "A",
                    11 => "Bb",
                    13 => "B",
                    _ => "C"
                };
            default:
                return position switch
                {
                    -9 => "C",
                    -7 => "C#",
                    -5 => "D",
                    -3 => "D#",
                    -1 => "E",
                    1 => "F",
                    3 => "F#",
                    5 => "G",
                    7 => "G#",
                    9 => "A",
                    11 => "A#",
                    13 => "B",
                    _ => "C"
                };
        }       
    }



    /// <summary>
    /// Method compares given key with existing tags
    /// </summary>
    /// <param name="pianoKey"></param>
    /// <returns></returns>
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