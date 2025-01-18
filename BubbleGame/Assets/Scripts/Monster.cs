using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public String _monsterName;
    public Color[] _colors;
    public int _score;
    public SpriteRenderer _spriteRenderer;

    public void InitialMonster(Color[] colors, int score, SpriteRenderer spriteRenderer){
        this._colors = colors;
        this._score = score;
        this._spriteRenderer = spriteRenderer;
    }
}

public enum Color
{
    Red,
    Green,
    Blue,
    Yellow
}



