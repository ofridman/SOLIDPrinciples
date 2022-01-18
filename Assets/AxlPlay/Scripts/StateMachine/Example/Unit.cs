using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public StateMachine stateMachine = new StateMachine();
    void Start()
    {
        stateMachine.ChangeState(new InitState(this));
        StartCoroutine(WaitFor());
    }
    private void Update()
    {
        stateMachine.Update();
    }

    private IEnumerator WaitFor()
    {

        yield return new WaitForSeconds(5f);
        var n = new NextState();
        n.owner = this;
        stateMachine.ChangeState(new NextState());

    }
}
