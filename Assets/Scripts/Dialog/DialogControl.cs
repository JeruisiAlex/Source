using Fungus;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogControl : MonoBehaviour
{
    public TextMeshProUGUI LeiQieEr, WuWenZhong, LiuSanQiang, LiJianGuo, AZheng, BookstoreBoss, Librarian, Bartender, Knight, Princess, Dragon, Teacher;
    private GameObject ob;
    private Flowchart f;
    private UpdateCharacterImage addnpc;
    // Start is called before the first frame update
    void Start()
    {
        f = GetComponent<Flowchart>();
        ob = GameObject.Find("CYZ");
        addnpc = ob.GetComponent<UpdateCharacterImage>();
    }

    public void AddNpc()
    {
        string npcname = f.GetStringVariable("AddNpcName");
        addnpc.UpdateImage(npcname);
        if(npcname == "LeiQieEr")
        {

        }
        else if (npcname == "WuWenZhong")
        {

        }
        else if (npcname == "LiuSanQiang")
        {

        }
        else if (npcname == "LiJianGuo")
        {

        }
        else if (npcname == "AZheng")
        {

        }
        else if (npcname == "BookstoreBoss")
        {

        }
        else if (npcname == "Librarian")
        {

        }
        else if (npcname == "Bartender")
        {

        }
        else if (npcname == "Knight")
        {

        }
        else if (npcname == "Princess")
        {

        }
        else if (npcname == "Dragon")
        {

        }
        else if (npcname == "Teacher Liu")
        {

        }
    }

    public void AddMemorandum()
    {

    }

    public void AddGuide()
    {

    }

    public void UpdateMoney()
    {
        int money = f.GetIntegerVariable("Money");
        int extraMoney = f.GetIntegerVariable("ExtraMoney");
        int cost = f.GetIntegerVariable("Cost");
        if (cost > extraMoney)
        {
            extraMoney = 0;
            cost = cost - extraMoney;
            money = money - cost;
        }
        else
        {
            extraMoney -= cost;
        }
        f.SetIntegerVariable("Money", money);
        f.SetIntegerVariable("ExtraMoney", extraMoney);
        //调用小丁的方法更新手机的Money

    }

    public void GoToNextDay()
    {
        int x = f.GetIntegerVariable("X");
        int y = f.GetIntegerVariable("Y");
        int z = f.GetIntegerVariable("Z");
        x = x - (100 - x) / 15;
        if(z < 60)
        {
            if (f.GetBooleanVariable("isInteractive"))
            {
                z--;
            }
            else
            {
                z -= 5;
            }
        }
        else if(z >= 60 && z < 80)
        {
            z++;
        }
        f.SetIntegerVariable("T", (x * (200 - x) + y * (200 - y) + z * (200 - z)) / (600 - x - y - z));
        int t = f.GetIntegerVariable("T");
        int day = f.GetIntegerVariable("T");
        day++;
        int money = f.GetIntegerVariable("Money");
        money -= 40;
        f.SetIntegerVariable("Day", day);
        f.SetIntegerVariable("Money", money);
        f.SetBooleanVariable("isInteractive", false);
        //调用手机UI的数据更新界面

        //设置npc的出场情况

    }

}
