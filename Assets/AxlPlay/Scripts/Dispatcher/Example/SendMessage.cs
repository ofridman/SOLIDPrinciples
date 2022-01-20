using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AxlPlay.Messages;

public class SendMessage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MessageDispatcher.SendMessage(gameObject, ConstData.COLOR, gameObject.GetComponent<MeshRenderer>().material, 4f);
        var c = gameObject.GetComponent<CapsuleCollider>();
        c.isTrigger = true;
    }
}
