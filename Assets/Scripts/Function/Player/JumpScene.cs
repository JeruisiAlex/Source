using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScene : MonoBehaviour
{
    private Move2D m2;
    private Move m;
    private CameraManager cameraManager;
    private Vector3 streetPos = new Vector3(987.66f, 0.46f, 999);
    private GameObject mainCamera;

    private void Start()
    {
        m = gameObject.GetComponent<Move>();
        m2 = gameObject.GetComponent<Move2D>();
        cameraManager = gameObject.GetComponent<CameraManager>();
        mainCamera = GameObject.FindWithTag("MainCamera");
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Ìø×ªÖÁ½ÖµÀ
        if(collision.gameObject.tag== "ChangeScene")
        {
            m.enabled = false;
            m2.enabled = true;
            cameraManager.enabled = false;
            transform.position = streetPos;
            mainCamera.GetComponent<Transform>().localPosition = new Vector3(0, 4.5f, -3);
            mainCamera.GetComponent<Transform>().localEulerAngles = new Vector3(17, 0, 0);
        }
    }
}
