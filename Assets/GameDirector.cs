using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 class GameDirector : MonoBehaviour
{
    float span = 1.0f;
    float delta = 0;
    GameObject Time_gauge;

    void Start()
    {
        this.Time_gauge = GameObject.Find("Time_gauge");
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            this.Time_gauge.GetComponent<Image>().fillAmount -= 0.01f;
        }
    }

    public void DecreaseHp()
    {
        this.Time_gauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
        
        
        
    
}

