/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Data
{
    public static readonly Dictionary<Tetromino, Vector2Int[]> Cells = new Dictionary<Tetromino, Vector2Int[]>()
    {
        { Tetromino.C, new Vector2Int[] { new Vector2Int(-1, 1)} },
        { Tetromino.D, new Vector2Int[] { new Vector2Int(-1, 1) } },
        { Tetromino.E, new Vector2Int[] { new Vector2Int( 1, 1)} },
        { Tetromino.F, new Vector2Int[] { new Vector2Int( 0, 1) } },
        { Tetromino.G, new Vector2Int[] { new Vector2Int( 0, 1)} },
        { Tetromino.A, new Vector2Int[] { new Vector2Int( 0, 1) } },
        { Tetromino.B, new Vector2Int[] { new Vector2Int(-1, 1) } },
    };
}