using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public float downSpeed; //下降速度 //2
    void Start()
    {
        
    }

    /*
        Update 是跟著幀數移動
        FixedUpdate 是跟著固定時間間隔執行
    */
    
    void FixedUpdate() 
    {
        transform.Translate(0, -downSpeed * Time.deltaTime, 0); //(x, y, z)        
    }
}
