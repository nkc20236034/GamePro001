using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Bullet : MonoBehaviour
{
  
    
    public float MoveSpeed = 20.0f;         // �ړ��l

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        // �ʒu�̍X�V
        transform.Translate(MoveSpeed * Time.deltaTime, 0, 0);
    }
    
}

