using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LucasHaley
{
    public class Door : MonoBehaviour
    {
        public bool isOpen;
        
        // We're using a closed and open Positions.
        // There are a lot of different ways to treat this. It could be
        // absolute (which is what we're using for now), relative (which is
        // probably better), or even specifically rotational or positional.
        public Vector3 positionClosed;
        public Vector3 positionOpen;

        public void ToggleOpen()
        {
            Debug.Log("Door: ToggleOpen");
            
            // First, we toggle the state
            isOpen = !isOpen;
            
            // Then we immediately move the door.
            // Again, this could be a ternary.
            if (isOpen)
            {
                transform.position = positionOpen;
            }
            else
            {
                transform.position = positionClosed;
            }
        }
    }
}