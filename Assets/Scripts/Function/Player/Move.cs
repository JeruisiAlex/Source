using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rig;
    private float inputX,inputY,angleY;
    public float speed = 3;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        angleY= transform.eulerAngles.y;
        transform.eulerAngles = new Vector3(0,angleY,0);
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");
        Vector3 input =(inputX*transform.right+inputY*transform.forward).normalized;
        rig.velocity = input*speed;
    }
}
