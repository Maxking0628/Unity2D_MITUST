using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float forceX;        //水平推力參數
    Rigidbody2D playerRigibody2D;
    private float toLeft =-1;   //向左移動
    private float toRight = 1;  //向右移動
    private float stop = 0;     //停在原地
    float directionX;   //暫存X

    void Start() //開始時
    {
        playerRigibody2D = GetComponent<Rigidbody2D>(); //找出這個物件身上有沒有叫做<Rigibody2D>的東西
    }


    void Update() //每一幀
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
        playerRigibody2D.AddForce(newDirection * forceX);   //推力
    }
}
