using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    private float leftBorder = -3;
    private float rightBorder = 3;
    
    private float initPositionY = 0.00f; //int��� float�B�I��
    [Range(2, 6)] public float spacingY;

    //private string TEMP = "Floor";
    void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            GameObject newGround = Instantiate(Resources.Load<GameObject>("Floor")); //("�a�O") ("Box")
            float newGroundPositionY = initPositionY - spacingY * i; //�q��l�y��(0,0,0)���U�s�W�T�Ӧa�O
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
