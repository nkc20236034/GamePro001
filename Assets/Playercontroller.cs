using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontllorer : MonoBehaviour
{
    public float fMoveSpeed = 7.0f;     // �ړ��l
    //---------------------------
    //          �ǉ�
    public GameObject MyShot_0;        // �e�̃Q�[���I�u�W�F�N�g
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
            // �e�̐���
            Instantiate(MyShot_0);
        }
    }

}
