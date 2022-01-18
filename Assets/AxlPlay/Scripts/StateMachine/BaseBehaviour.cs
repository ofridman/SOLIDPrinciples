using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBehaviour : MonoBehaviour 
{
    public StateMachine stateMachine = new StateMachine();

    public void Enter()
    {
        Debug.Log("BaseBehaviour Enter");
    }

    public void Execute()
    {
        Debug.Log("BaseBehaviour Execute");
    }

    public void Exit()
    {
        Debug.Log("BaseBehaviour Exit");
    }

    private void Update()
    {
        stateMachine.Update();
    }

   

}
