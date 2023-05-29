using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontllorer : MonoBehaviour
{
    public float fMoveSpeed = 7.0f;     // 移動値
    //---------------------------
    //          追加
    public GameObject MyShot_0;        // 弾のゲームオブジェクト
    //---------------------------
    
    void Start()
    {
        

        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0, -0.1f, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0, 0.1f, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.1f, 0,0);
        }
        
        if (Input.GetButtonDown("Fire1"))
        {
            // 弾の生成
            Instantiate(MyShot_0);
        }
    }

}
