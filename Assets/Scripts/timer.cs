using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float timePassed = 0;
    public Text timeText;
    public Text recordText;
    public bool timerIsRunning = false;
    public bool GameEnd = false;
    public PauseGame pause;

    
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        Debug.Log(PlayerPrefs.GetFloat("record"));
        float record = PlayerPrefs.GetFloat("record");

        float minutesrecord = Mathf.FloorToInt(record / 60);
        float secondsrecord = Mathf.FloorToInt(record % 60);
        float milliSecondsrecord = (record % 1) * 1000;

        recordText.text = "HighScore: " + string.Format("{0:00}:{1:00}:{2:000}", minutesrecord, secondsrecord, milliSecondsrecord);
    }

    // Update is called once per frame
    void Update()
    {
        if (pause.GameIsPaused)
        {
            timerIsRunning = false;
        }
        else
        {
            timerIsRunning = true;
        }

        if (timerIsRunning && GameEnd== false)
        {
           
            timePassed += Time.deltaTime;
            this.DisplayTime(timePassed);
        }
    }

    public void StartStopTimer(bool timerShouldStop)
    {
        if (timerShouldStop)
        {
            PlayerPrefs.SetFloat("record",timePassed);
            GameEnd = true;
            timerIsRunning = false;
        }
        else
        {
            GameEnd = false;
            timerIsRunning = true;
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliSeconds = (timeToDisplay % 1) * 1000;

        timeText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliSeconds);

    }
}

