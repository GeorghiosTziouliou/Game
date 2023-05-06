using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    // public Text tipText; // reference to the text object that displays the tip

    // function to be called when the button is clicked
    void OnTriggerEnter(Collider other)
    {
        
            Debug.Log("Player collided with button");
            // tipText.text = "This is a tip on how to play the level!"; // set the tip text
            // tipText.gameObject.SetActive(true); // display the text object
        
    }


}