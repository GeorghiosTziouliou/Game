using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelEndTrigger : MonoBehaviour
{
    private bool levelComplete = false;
    
    

    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player") && !levelComplete) 
        {
            LevelTimer levelTimer = FindObjectOfType<LevelTimer>();
            levelTimer.StopTimer();
            levelComplete = true;
        }
    }
}