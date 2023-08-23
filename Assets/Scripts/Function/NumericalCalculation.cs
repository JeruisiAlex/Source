using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.Rendering.UI;

public class NumericalCalculation : MonoBehaviour
{
    // Start is called before the first frame update
    Flowchart flowchart;
    void Start()
    {
        flowchart = GetComponent<Flowchart>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int x = flowchart.GetIntegerVariable("X");
        int y = flowchart.GetIntegerVariable("Y");
        int z = flowchart.GetIntegerVariable("Z");
        flowchart.SetIntegerVariable("T", (x * (200 - x) + y * (200 - y) + z * (200 - z)) / (600 - x - y - z));
    }
}
