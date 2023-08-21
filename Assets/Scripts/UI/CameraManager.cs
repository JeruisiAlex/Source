using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(RotateLittleAngle(-45, 0.2f));
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(RotateLittleAngle(45, 0.2f));
        }
    }

    IEnumerator RotateLittleAngle(float angle,float time)
    {
        //旋转次数
        float number = 60 * time;
        //每次旋转角度
        float littleAngle = angle/number;
        //每帧旋转
        for(int i=0; i < number; i++)
        {
            transform.Rotate(new Vector3(0, littleAngle, 0));
            yield return new WaitForFixedUpdate();
        }

    }
}
