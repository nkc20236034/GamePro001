using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 class GameDirector : MonoBehaviour
{
    float span = 1.0f;
    float delta = 0;
    float meter = 0;
    GameObject Time_gauge;
    GameObject meterText;
    
  
    void Start()
    {
        Application.targetFrameRate = 60;
        this.Time_gauge = GameObject.Find("Time_gauge");
        this.meterText = GameObject.Find("meterText");

    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            this.Time_gauge.GetComponent<Image>().fillAmount -= 0.01f;
        }

        this.meter += Time.deltaTime * 60.0f;
        this.meterText.GetComponent<Text>().text = this.meter.ToString("F1") + "km";
        this.delta += Time.deltaTime;


    }


    public void DecreaseHp()
    {
        this.Time_gauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
        
        
        
    
}

