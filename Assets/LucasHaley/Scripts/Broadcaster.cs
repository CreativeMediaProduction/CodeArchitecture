using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace LucasHaley
{
    public class Broadcaster : MonoBehaviour
    {
        public UnityEvent receiverList;

        public void broadcast()
        {
            receiverList.Invoke();
        }
    }
}