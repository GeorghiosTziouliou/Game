using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;

public class LevelTimer : MonoBehaviour
{
    private float startTime;
    private bool isRunning = true;
    private TimeSpan elapsedTimeSpan;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI timerTextEnd;
    public Canvas endCanvas;
    public Canvas StartingCanvas;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (isRunning) {
            float elapsedTime = Time.time - startTime;
            elapsedTimeSpan = TimeSpan.FromSeconds(elapsedTime);
            string timeString = string.Format("{0:00}:{1:00}", elapsedTimeSpan.Minutes, elapsedTimeSpan.Seconds);
            timerText.text = timeString; // Update the text on the UI
        }
    }

    // Stop the timer and return the elapsed time
    public float StopTimer()
    {
        isRunning = false;
        timerTextEnd.text = ((float)elapsedTimeSpan.TotalSeconds).ToString(CultureInfo.InvariantCulture);
        Cursor.lockState = CursorLockMode.None; // Release the mouse cursor
        Cursor.visible = true; // Show the mouse cursor
        StartingCanvas.gameObject.SetActive(false);
        endCanvas.gameObject.SetActive(true);
        return (float)elapsedTimeSpan.TotalSeconds;
    }


}