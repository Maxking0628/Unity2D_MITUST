using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public float downSpeed; //�U���t�� //2
    void Start()
    {
        
    }

    /*
        Update �O��۴V�Ʋ���
        FixedUpdate �O��۩T�w�ɶ����j����
    */
    
    void FixedUpdate() 
    {
        transform.Translate(0, -downSpeed * Time.deltaTime, 0); //(x, y, z)        
    }
}
