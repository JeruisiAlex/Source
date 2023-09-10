using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogControl : MonoBehaviour
{
    private GameObject ob;
    private Flowchart f;
    // Start is called before the first frame update
    void Start()
    {
        f = GetComponent<Flowchart>();
        ob = GameObject.Find("");
    }

    public void AddNpc()
    {
        string npcname = f.GetStringVariable("AddNpcName");
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
