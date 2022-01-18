using System;
using UnityEngine.Events;

namespace AxlPlay.Messages
{
    [Serializable]
    public class MessageEvent : UnityEvent<IMessage>
    {
    }
}
