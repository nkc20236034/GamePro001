using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 class GameDirector : MonoBehaviour
{
    GameObject Time_gauge;

    void Start()
    {
        this.Time_gauge = GameObject.Find("Time_gauge");
    }

    public void DecreaseHp()
    {
        this.Time_gauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}

