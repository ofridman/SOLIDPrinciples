using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropObject : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    private void OnMouseDown()
    {

        mZCoord = Camera.main.WorldToViewportPoint(gameObject.transform.position).z;
        Debug.Log("Z:" + gameObject.transform.position.z);

        mOffset = gameObject.transform.position - GetMouseWorldPos(); 
    }
    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        Debug.Log("Z:" + mousePoint.z);
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint); ;
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
     }

}
