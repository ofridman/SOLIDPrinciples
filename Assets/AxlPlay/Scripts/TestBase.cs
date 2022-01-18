using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBase : MonoBehaviour, IRayProvider
{
    public Ray CreateRay()
    {
        Debug.Log("CreateRay");

        return new Ray();
    }

     
}
