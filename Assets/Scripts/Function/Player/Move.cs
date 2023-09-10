using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rig;
    private Animator aim;
    private float inputX,inputY,angleY;
    private bool isTurn;
    public float speed = 3;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        aim = GetComponent<Animator>();
        rig.freezeRotation = true;
        isTurn = true;
    }
    void FixedUpdate()
    {
        angleY= transform.eulerAngles.y;
        transform.eulerAngles = new Vector3(0,angleY,0);
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");
        Vector3 input =(inputX*transform.right+inputY*transform.forward).normalized;
        rig.velocity = input*speed;
        if (input * speed != Vector3.zero) aim.SetBool("isMove", true);
        else aim.SetBool("isMove", false);
        if (!isTurn && inputX > 0) Flip();
        else if(isTurn && inputX < 0) Flip();
    }

    private void Flip()
    {
        Vector3 playerScale = rig.transform.localScale;
        playerScale.x *= -1;
        rig.transform.localScale = playerScale;
        isTurn = !isTurn;
    }
}
