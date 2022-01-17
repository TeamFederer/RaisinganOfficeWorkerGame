using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stock_Samsung : MonoBehaviour
{
    public static int stock_id = 0;
    public static string stockName = "»ï¼º";
    public static float price = 50000f;
    public static List<int> stockValue = new List<int> { 10, 100, 1000, 10000, 100000 };
    protected float changeRange;
    protected bool isIncrease;
    protected bool isDecrease;
}


//List<int> Samsung = new List<int> { 10, 100, 1000, 10000, 100000 };
//List<int> Tesla = new List<int> { 1245, 1100, 1020, 1210, 1350 };
//List<int> Google = new List<int> { 2780, 2850, 2900, 2860, 2920 };