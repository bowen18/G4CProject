using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool TimerOn=false;

    public Text timerText;
    public Text timerResult;

    private float currentTime;
    private float finalTime;

    public float bronzeM;
    public float silverM;
    public float goldM;


    void Start()
    {
        currentTime=Time.time;
        UpdateTimer(currentTime);
    }


    void Update()
    {
        if(TimerOn)
        {
            currentTime+=Time.deltaTime;
            UpdateTimer(currentTime);
        }
    }

    public void TimerBegin()
    {
        TimerOn=true;
    }

    void UpdateTimer(float currentTime)
    {
        float minutes=Mathf.FloorToInt(currentTime / 60);
        float seconds=Mathf.FloorToInt(currentTime % 60);

        timerText.text=string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    void TimeMedal(float currentTime)
    {
        if(bronzeM>=currentTime && currentTime>silverM)
        {
            timerResult.text="You got the Bronze Medal.";
        }else if(silverM>=currentTime && currentTime>goldM)
        {
            timerResult.text="You got the silver Medal.";
        }else if(goldM>=currentTime)
        {
            timerResult.text="You got the gold Medal.";
        }else
        {
            timerResult.text="You took too long, try completing the level faster.";
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag=="Player")
        {
            TimerOn=false;
            TimeMedal(currentTime);
        }
    }
}
