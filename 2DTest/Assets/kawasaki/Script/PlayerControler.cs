using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{   
    public float speed = 5.0f;           //�ړ��X�s�[�h
    float axisH;                         //�c��
    float axisV;                         //����
    Rigidbody2D rbody;                   //Rigidbody2D
   

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();    //Rigidbody2D�𓾂�
    }

    // Update is called once per frame
    void Update()
    {
        axisH = Input.GetAxisRaw("Horizontal");     //���E�L�[����
        axisV = Input.GetAxisRaw("Vertical");       //�㉺�L�[����

      

    }

    private void FixedUpdate()
    {
        //���x�X�V
        rbody.velocity = new Vector2(axisH, axisV).normalized * speed;
    }
}
