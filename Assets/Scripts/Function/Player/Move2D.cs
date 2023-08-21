using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    private Rigidbody rig;
    private float inputX;
    public float speed = 3;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0,0,0);
        inputX = Input.GetAxisRaw("Horizontal");
        Vector3 input =(inputX*transform.right).normalized;
        rig.velocity = input*speed;
    }
}
