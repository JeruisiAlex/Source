using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScene : MonoBehaviour
{
    private Move2D m2;
    private Move m;
    public Vector3 newPos = new Vector3(995f, 0.7f, 999);
    private GameObject mainCamera;
    public Animator animator;
    public bool isTOEM = false;
    public GameObject F;

    private void Start()
    {
        m = GameObject.FindWithTag("Player").GetComponent<Move>();
        m2 = GameObject.FindWithTag("Player").GetComponent<Move2D>();
        mainCamera = GameObject.Find("MainCamera");
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
            mainCamera.GetComponent<Transform>().localPosition = new Vector3(0, 8, -3);
            mainCamera.GetComponent<Transform>().localEulerAngles = new Vector3(45, 0, 0);
        }
        else
        {
            m.enabled = false;
            m2.enabled = true;
            mainCamera.GetComponent<Transform>().localPosition = new Vector3(5, 0, -15);
            mainCamera.GetComponent<Transform>().localEulerAngles = new Vector3(10, 0, 0);
        }

        GameObject.FindWithTag("Player").transform.position = newPos;

    }
}
