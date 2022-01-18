using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextState : IState
{
    public Unit owner;
    //public NextState(Unit owner) { this.owner = owner; }
    public NextState() {}

    public void Enter()
    {
        Debug.Log("Enter NextState");
    }

    public void Execute()
    {
       
    }

    public void Exit()
    {
        
    }
}
