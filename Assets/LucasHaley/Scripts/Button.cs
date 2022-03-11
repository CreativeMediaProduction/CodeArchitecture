using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Note how I've put all of my code into a namespace
namespace LucasHaley
{
    public class Button : MonoBehaviour
    {
        // Variables
        public bool isOn;
        public Color colorOn;
        public Color colorOff;
        
        // We're explicitly saying we only work with Doors, and only
        // one door in particular. This could be better.
        public Door targetDoor;

        // This is when something collides with our button
        // Usually you will want to filter which things can collide
        // Some of the filtering happens in the Physics matrix
        // Some happens in this code using either layers or tags.
        // Note that we're not using this anymore -- the CharacterController
        // doesn't interact with the Physics engine. But I'll leave it here anyway,
        // as it's useful if we were rolling our own physics-based controller.
        public void OnCollisionEnter(Collision other)
        {
            Debug.Log("Button: OnCollisionEnter");
            
            // To start with, we'll just go straight to DoInteraction.
            DoInteraction();
        }

        // This is the main point of interaction.
        // We're not putting this directly into the OnCollisionEnter,
        // for a couple of reasons:
        // 1. We might want to call it without having a collision, like with a timer
        // 2. We can access it outside of the collision, which in this case is excellent
        // because we've discovered that the CharacterController doesn't engage the
        // physics engine.
        public void DoInteraction()
        {
            Debug.Log("Button: DoInteraction");
            
            // First, we can toggle the state of the button.
            isOn = !isOn;
            // At the moment, these calls are hard-coded. We'll have to refactor if we
            // want more flexibility.
            ToggleColor();
            targetDoor.ToggleOpen();
        }

        // This toggles the material color between the two variables.
        public void ToggleColor()
        {
            Debug.Log("Button: ToggleColor");
            
            // At the moment, we're using a simple If statement
            // but this could also be a Ternary switch

            if (isOn)
            {
                gameObject.GetComponent<Renderer>().material.color = colorOn;
            }
            else
            {
                gameObject.GetComponent<Renderer>().material.color = colorOff;
            }
        }
    }
}
