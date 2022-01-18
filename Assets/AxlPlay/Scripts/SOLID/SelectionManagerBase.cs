using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManagerBase : MonoBehaviour , IRayProvider
{
    public string BaseProperty;
    public virtual void TestMethod() 
    {
        Debug.Log("BASE - TestMethod");
    } 
  
    public Ray CreateRay()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }
}
