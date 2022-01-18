using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitState : IState
{
    Unit owner;

    public InitState(Unit owner) { this.owner = owner; }

    public void Enter()
    {
 
        Debug.Log("Enter InitState");

    }

    public void Execute()
    {
        //Debug.Log("updating test state");
    }

    public void Exit()
    {
        Debug.Log("Exit InitState");
    }

}
