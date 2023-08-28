using Fungus;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using XCharts.Runtime;

public class UpdateData : MonoBehaviour
{
    public TextMeshProUGUI MoneyText,DayText,WeekText;
    public LineChart lineChart;
    private string[] week = { "����һ", "���ڶ�", "������", "������" ,"������","������","������"};
    private string name1 = "��Ⱦ����ָ��", name2 = "԰������̶�", name3 = "Ⱥ�ڻ�����ʶ", name4 = "���л���ָ��";
    private Flowchart flowChart;


    private void Start()
    {
        flowChart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
        UpdateDayAndLog(flowChart.GetIntegerVariable("Day"), flowChart.GetIntegerVariable("X"), flowChart.GetIntegerVariable("Y"), flowChart.GetIntegerVariable("Z"), flowChart.GetIntegerVariable("T"));
        UpdateMoney(flowChart.GetIntegerVariable("Money"));
    }

    public void UpdateMoney(int money)
    {
        MoneyText.text = money.ToString();
    }

    public void UpdateDayAndLog(int day,int x,int y,int z,int t)
    {
        WeekText.text = week[day % 7 - 1];
        DayText.text = "��" + day.ToString() + "��";

        lineChart.AddXAxisData(day.ToString());
        lineChart.AddData(name1, x);
        lineChart.AddData(name2, y);
        lineChart.AddData(name3, z);
        lineChart.AddData(name4, t);
    }
}
