using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private GameManager gameManager;

    [Header("TimerStarter/Config")]
    public bool TimerStart = false;
    public bool showMilliseconds;

    public float currentSeconds;
    private int timerDefaut;

    [Header("Switch StopWatch")]
    public bool StopWatch = false;
    public Text timerText;

    [Header("Time Values")]
    [Range(0, 60)]
    public int seconds;
    [Range(0, 60)]
    public int minutes;
    [Range (0, 60)] 
    public int hours;

    public Color fontColor;
   

    void Start()
    {
        
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (StopWatch == true)
        {
            seconds = 0;
            minutes = 0;
            hours = 0;
        }
        timerText.color = fontColor;
        timerDefaut = 0;
        timerDefaut +=(seconds + (minutes * 60) + (hours * 60 * 60));
        currentSeconds = timerDefaut;
       
    }
  
    void Update()
    {
        if(gameManager.ResumeTime == true)
        {
            TimerStart = true;
        }
        else
        {
            TimerStart = false;
        }
        if (TimerStart == true ) 
        {
            StartTimer();
        }

      
    }

    public void StartTimer()
    {
        if (StopWatch == false)
        {
            if ((currentSeconds -= Time.deltaTime) <= 0)
            {
                TimerUp();
               
            }
            else
            {
                if (showMilliseconds == true)
                {
                    timerText.text = TimeSpan.FromSeconds(currentSeconds).ToString(@"hh\:mm\:ss\:fff");
                }
                else
                {
                    timerText.text = TimeSpan.FromSeconds(currentSeconds).ToString(@"hh\:mm\:ss");
                }
            }
        }
        else
        {
            if ((currentSeconds += Time.deltaTime) <= 0)
            {
                TimerUp();
              
            }
            else
            {
                if (showMilliseconds == true)
                {
                    timerText.text = TimeSpan.FromSeconds(currentSeconds).ToString(@"hh\:mm\:ss\:fff");
                }
                else
                {
                    timerText.text = TimeSpan.FromSeconds(currentSeconds).ToString(@"hh\:mm\:ss");
                }
            }
        }

    }

    private void TimerUp()
    {
        TimerUp_Descanso();
        if (showMilliseconds == true)
        {
            timerText.text = "00:00:00:00";
        }
        else
        {
            timerText.text = "00:00:00";
        }
       
    }
    public void TimerUp_Descanso()
    {
        gameManager.Descanso();
        TimerStart = false;

        seconds = seconds;
        minutes = minutes;
        hours = hours;

        timerDefaut = 0;
        timerDefaut += (seconds + (minutes * 60) + (hours * 60 * 60));
        currentSeconds = timerDefaut;

    }
}
