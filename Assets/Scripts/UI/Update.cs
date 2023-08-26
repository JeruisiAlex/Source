using Fungus;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Update : MonoBehaviour
{
    public TextMeshProUGUI MoneyText,DayText,WeekText;
    private string[] week = { "星期一", "星期二", "星期三", "星期四" ,"星期五","星期六","星期天"};

    public void UpdateMoneyAndDay(int day,int money)
    {
        DayText.text = "第" + day.ToString() + "天";
        MoneyText.text = money.ToString();
        WeekText.text = week[day%7-1];
    }
}
