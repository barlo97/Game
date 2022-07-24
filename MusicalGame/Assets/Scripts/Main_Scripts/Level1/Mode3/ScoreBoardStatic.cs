/*
 Copyright (c) Józef Yika
*/

public static class ScoreBoardStatic
{
    #region Variables
    private static int scoreAPoint;
    public static int ScoreAPoint
    {
        get { return scoreAPoint; }

    }

    #endregion

    #region Unity Methods

    public static void  IncrementPoints ()
    {
        scoreAPoint++; 
    }

    public static void DecrementPoints() => scoreAPoint--;

    public static void ResetPoints() => scoreAPoint = 0;
   


    #endregion
}
