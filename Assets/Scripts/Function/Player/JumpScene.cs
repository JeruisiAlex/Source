using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScene : MonoBehaviour
{
    private Move2D m2;
    private Move m;
    private CameraManager cameraManager;
    public Vector3 newPos = new Vector3(987.66f, 0.46f, 999);
    private GameObject mainCamera;
    public Animator animator;
    public bool isTOEM = false;
    public GameObject F;

    private void Start()
    {
        m = GameObject.FindWithTag("Player").GetComponent<Move>();
        m2 = GameObject.FindWithTag("Player").GetComponent<Move2D>();
        cameraManager = GameObject.FindWithTag("Player").GetComponent<CameraManager>();
        mainCamera = GameObject.FindWithTag("MainCamera");
    }

    private void OnTriggerStay(Collider other)
    {
        F.SetActive(true);
        if(other.gameObject.tag== "Player" && Input.GetKeyDown(KeyCode.F))
        {
            LoadNextScene();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        F.SetActive(false);
    }

    private void LoadNextScene()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        animator.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        animator.SetTrigger("Start");

        if (isTOEM)
        {
            m.enabled = true;
            m2.enabled = false;
            cameraManager.enabled = true;
            mainCamera.GetComponent<Transform>().localPosition = new Vector3(0, 8, -3);
            mainCamera.GetComponent<Transform>().localEulerAngles = new Vector3(45, 0, 0);
        }
        else
        {
            m.enabled = false;
            m2.enabled = true;
            cameraManager.enabled = false;
            mainCamera.GetComponent<Transform>().localPosition = new Vector3(0, 4.5f, -3);
            mainCamera.GetComponent<Transform>().localEulerAngles = new Vector3(17, 0, 0);
        }

        GameObject.FindWithTag("Player").transform.position = newPos;

    }
}
