using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    private float leftBorder = -3;
    private float rightBorder = 3;
    
    private float initPositionY = 0.00f; //int整數 float浮點數
    [Range(2, 6)] public float spacingY;

    //private string TEMP = "Floor";
    void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            GameObject newGround = Instantiate(Resources.Load<GameObject>("Floor")); //("地板") ("Box")
            float newGroundPositionY = initPositionY - spacingY * i; //從初始座標(0,0,0)往下新增三個地板
            newGround.transform.position = new Vector3(NewGroundPositionX(), newGroundPositionY, 0);
        }
    }

    float NewGroundPositionX() //Position X(-3,3)
    {
        return Random.Range(leftBorder, rightBorder);
    }

    void Update()
    {
        
    }
}
