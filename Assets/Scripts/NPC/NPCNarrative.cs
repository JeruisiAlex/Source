using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class NPCNarrative : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("npcNameΪ��ǰnpc������,dialogTagΪ��Ҫ���������Ի����˵�tag")]
    public string npcName;
    public string dialogTag = "Player";
    private Flowchart flowchart;
    private bool canSsy;
    void Start()
    {
        canSsy = false;
        flowchart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Say();
        }
    }
    private void Say()
    {
        if (canSsy)
        {
            if (flowchart.HasBlock(npcName))
            {
                flowchart.ExecuteBlock(npcName);
                canSsy=false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals(dialogTag))
        {
            canSsy = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals(dialogTag))
        {
            canSsy = false;
        }
    }
}
