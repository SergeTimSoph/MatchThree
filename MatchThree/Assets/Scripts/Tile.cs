﻿using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField]
    private int xIndex;
    [SerializeField]
    private int yIndex;

    private Board board;

    public void Init(int xIndex, int yIndex, Board board)
    {
        this.xIndex = xIndex;
        this.yIndex = yIndex;
        this.board = board;
    }
}