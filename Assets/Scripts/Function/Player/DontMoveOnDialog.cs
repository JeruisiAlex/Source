using Fungus;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontMoveOnDialog : MonoBehaviour
{
    private Flowchart flowchart;
    public bool isTOEM;
    private Boolean isDialog;

    private void Start()
    {
        flowchart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
    }
    private void FixedUpdate()
    {
        isDialog = flowchart.GetBooleanVariable("isDialog");
        if (isDialog)
        { 
            StopMovingOrRotating();
        }
        else
        {
            ContinueMovingAndRotating();
        }
    }

    private bool JudgeTheScene()
    {
        return gameObject.GetComponent<Move>().enabled;
    }

    private void StopMovingOrRotating()
    {
        if (isTOEM)
        {
            gameObject.GetComponent<Move>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<Move2D>().enabled = false;
        }
        gameObject.GetComponent<OpenPhone>().enabled = false;
    }

    private void ContinueMovingAndRotating()
    {
        if (isTOEM)
        {
            gameObject.GetComponent<Move>().enabled = true;
            gameObject.GetComponent<Move2D>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<Move2D>().enabled = true;
            gameObject.GetComponent<Move>().enabled = false;
        }
        gameObject.GetComponent<OpenPhone>().enabled = true;
    }
}
