using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CreateMenu : MonoBehaviour
{

    // Add a menu item named "Do Something" to MyMenu in the menu bar.
    [MenuItem("ATF/Create Part")]
    static void CreatePart()
    {
        Debug.Log("Creating part...");
    }
}
