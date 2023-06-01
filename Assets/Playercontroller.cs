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
    //�A�j���[�^�[�R���|�[�l���g��ۑ�����ϐ�
    Animator anim;
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, -90));
       
        //�A�j���[�^�[�R���|�[�l���g��anim�ϐ��ɕۑ�
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
            // �e�̐���
            Instantiate(MyShot_0);
        }
    }

}
