using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private Vector3 defaultRotate;
    private bool isRotate = false;

    private void Update()
    {
        Rotate();
        if (isRotate == false)
        {
            transform.eulerAngles = defaultRotate;
        }
    }

    private void Rotate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(RotateLittleAngle(45, 0.2f));
            isRotate = true;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(RotateLittleAngle(-45, 0.2f));
            isRotate = true;
        }
    }

    IEnumerator RotateLittleAngle(float angle,float time)
    {
        //��ת����
        float number = 60 * time;
        //ÿ����ת�Ƕ�
        float littleAngle = angle/number;
        //ÿ֡��ת
        for(int i=0; i < number; i++)
        {
            transform.Rotate(new Vector3(0, littleAngle, 0));
            yield return new WaitForFixedUpdate();
        }
        defaultRotate = transform.eulerAngles;
        isRotate = false;
    }
}
