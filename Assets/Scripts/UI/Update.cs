using Fungus;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Update : MonoBehaviour
{
    public TextMeshProUGUI MoneyText,DayText,WeekText;
    private string[] week = { "����һ", "���ڶ�", "������", "������" ,"������","������","������"};

    public void UpdateMoneyAndDay(int day,int money)
    {
        DayText.text = "��" + day.ToString() + "��";
        MoneyText.text = money.ToString();
        WeekText.text = week[day%7-1];
    }
}
