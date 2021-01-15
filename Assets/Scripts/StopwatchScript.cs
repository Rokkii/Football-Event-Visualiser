using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopwatchScript : MonoBehaviour
{

    float timer = 0.0f;
    float seconds = 0.0f;
    float minutes = 0.0f;

    bool timerStart;

    public Text stopwatchText;

    [SerializeField]
    Text editStopwatchText;

    [SerializeField]
    GameObject startButton;

    [SerializeField]
    GameObject stopButton;

    [SerializeField]
    GameObject editTimerWindow;

    // Start is called before the first frame update
    void Start()
    {
        timerStart = false;
        startButton.SetActive(true);
        stopButton.SetActive(false);
        editTimerWindow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        StopwatchCalculate();
    }

    void StopwatchCalculate()
    {
        if (timerStart)
        {
            UpdateTimer();
        }
    }

    void UpdateTimer()
    {
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        minutes = (int)(timer / 60);

        stopwatchText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        editStopwatchText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }

    public void StartTimer()
    {
        timerStart = true;
        startButton.SetActive(false);
        stopButton.SetActive(true);
    }

    public void StopTimer()
    {
        timerStart = false;
        startButton.SetActive(true);
        stopButton.SetActive(false);
    }

    public void EditTimer()
    {
        timerStart = false;
        editTimerWindow.SetActive(true);
        startButton.SetActive(true);
        stopButton.SetActive(false);
    }

    public void CloseTimerEditor()
    {
        editTimerWindow.SetActive(false);
    }

    public void ChangeTime(float timeMod)
    {
        timerStart = false;

        timer += timeMod;
        
        if (timer <= 0)
        {
            timer = 0;
        }

        UpdateTimer();
    }
}
