using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlacement  
{
    void OnDrag();
    void OnDragEnd();
    void OnSnap();
}
