/*
 Copyright (c) Józef Yika
*/
using UnityEngine;
using UnityEngine.Tilemaps;
public enum Tetromino
{
    C,
    C_Sharp,
    D,
    D_Sharp,
    E,
    F,
    F_Sharp,
    G,
    G_Sharp,
    A,
    A_Sharp,
    B,
    

}

[System.Serializable]
public struct TetrominoData
{
    public Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells { get; private set; }

    public void Initialize()
    {
        this.cells = Data.Cells[this.tetromino];
    }
}
