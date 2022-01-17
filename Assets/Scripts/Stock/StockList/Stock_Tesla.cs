using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stock_Tesla : MonoBehaviour
{
    public static int stock_id = 1;
    public static string stockName = "ев╫╫╤С";
    public static float price = 1400f;
    public static List<int> stockValue = new List<int> { 1245, 1100, 1020, 1210, 1350 };
    protected float changeRange;
    protected bool isIncrease;
    protected bool isDecrease;
}
