using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float forceX;        //�������O�Ѽ�
    Rigidbody2D playerRigibody2D;
    private float toLeft =-1;   //�V������
    private float toRight = 1;  //�V�k����
    private float stop = 0;     //���b��a
    float directionX;   //�ȦsX

    void Start() //�}�l��
    {
        playerRigibody2D = GetComponent<Rigidbody2D>(); //��X�o�Ӫ��󨭤W���S���s��<Rigibody2D>���F��
    }


    void Update() //�C�@�V
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            directionX = toLeft;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            directionX = toRight;
        }
        else
        {
            directionX = stop;
        }
        Vector2 newDirection = new Vector2(directionX, 0);  //Right(1,0), Left(-1,0), Stop(0,0)
        playerRigibody2D.AddForce(newDirection * forceX);   //���O
    }
}
