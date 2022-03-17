using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LucasHaley
{
    public class PlayerColliderBroadcast : MonoBehaviour
    {
        // This method gets called whenever the player touches a Collider.
        // But it _doesn't_ use the physics engine, for optimisation.
        private void OnControllerColliderHit(ControllerColliderHit hit)
        {
            Debug.Log("PlayerCollider: OnControllerColliderHit");

            // We've hit something!
            // First, let's check if it's a Button, as we can only interact
            // with Buttons for now.
            // We declare a variable "button" of type Button, and try to grab
            // it from the thing we hit.
            Broadcaster broadcaster = hit.gameObject.GetComponent<Broadcaster>();

            // exit this code if it's not a Door.
            if (broadcaster == null) return;

            // Otherwise, tell it to do it's thing
            broadcaster.broadcast();
        }
    }
}
