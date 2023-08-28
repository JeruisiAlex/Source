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
    private string[] week = { "星期一", "星期二", "星期三", "星期四" ,"星期五","星期六","星期天"};
    private string name1 = "污染处理指数", name2 = "园区建设程度", name3 = "群众环保意识", name4 = "城市环保指数";
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
        DayText.text = "第" + day.ToString() + "天";

        lineChart.AddXAxisData(day.ToString());
        lineChart.AddData(name1, x);
        lineChart.AddData(name2, y);
        lineChart.AddData(name3, z);
        lineChart.AddData(name4, t);
    }
}
