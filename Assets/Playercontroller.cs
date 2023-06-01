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
    //アニメーターコンポーネントを保存する変数
    Animator anim;
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, -90));
       
        //アニメーターコンポーネントをanim変数に保存
        anim = GetComponent<Animator>();

        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Vertical");

        if (x == 0)
        {
            anim.Play("Player");
        }
        else if (x == 1)
        {
            anim.Play("PlayerR");
        }
        else
        {
            anim.Play("PlayerL");
        }

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
