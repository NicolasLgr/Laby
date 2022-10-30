using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public Text timerText;
    public float gameTime;

    private bool stopTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        stopTimer = false;
        
    }

    private void Update()
    {
        float time = gameTime - Time.time;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60);

        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        if (time <= 0 )
        {
            stopTimer = true;
        }

        if (!stopTimer)
        {
            timerText.text = textTime;
        }
    }
}
