using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class Player
{
    public delegate void PositionEvent(Vector3 position);
    public event PositionEvent OnPositionChanged;

    public Vector3 position
    {
        get
        {
            return _position;
        }
        set
        {
            if (_position != value)
            {
                _position = value;
                if (OnPositionChanged != null)
                {
                    OnPositionChanged(value);
                }
            }
        }
    }
    private Vector3 _position;
}