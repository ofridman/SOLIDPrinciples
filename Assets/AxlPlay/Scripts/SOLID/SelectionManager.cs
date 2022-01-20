using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SelectionManager : SelectionManagerBase // , IRayProvider
{
    // one way
    //private IRayProvider _rayProvider;
    private ISelector _selector;
    private ISelectionResponse _selectionResponse;


    private Transform _currentSelection;


    private void Awake()
    {

        // only for example -> loose coupling
        //we don't need to know the name of the script  
        var ss = FindObjectsOfType<MonoBehaviour>().OfType<IRayProvider>();

        foreach (IRayProvider s in ss)
        {
            s.CreateRay();
        }

        // One way
        // _rayProvider = GetComponent<IRayProvider>();
        _selector = GetComponent<ISelector>();
        _selectionResponse = GetComponent<ISelectionResponse>();
        
        TestMethod();

    }

    private void Start()
    {
        var obj = SingletonTest.Instance.player;
    }

    private void Update()
    {
        if (_currentSelection != null)
            _selectionResponse.OnDeselect(_currentSelection);

        // one way
        // _selector.Check(_rayProvider.CreateRay());

        // another way
        _selector.Check(CreateRay());

        _currentSelection = _selector.GetSelection();

        if (_currentSelection != null)
            _selectionResponse.OnSelect(_currentSelection);
    }

    public override void TestMethod()
    {
        base.TestMethod();

        Debug.Log("TestMethod");
    }

    #region IRayProvider

    // and a Third way
    public Ray CreateRay()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    #endregion
}
