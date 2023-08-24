using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {


        //当前对象始终面向摄像机。
        this.transform.LookAt(Camera.main.transform.position);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(Camera.main.transform.position - this.transform.position), 0);
    }
}