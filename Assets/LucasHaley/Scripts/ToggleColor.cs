using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LucasHaley
{
    public class ToggleColor : MonoBehaviour
    {
        public bool isOn;
        public Color colorOn;
        public Color colorOff;

        // Start is called before the first frame update
        void Start()
        {
            DoToggleColor();
        }

        public void DoInteraction()
        {
            Debug.Log("Button: DoInteraction");
            
            isOn = !isOn;
            DoToggleColor();
        }

        private void DoToggleColor()
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