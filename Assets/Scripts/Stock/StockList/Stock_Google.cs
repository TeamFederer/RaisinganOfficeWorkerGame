using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stock_Google : MonoBehaviour
{
    public static int stock_id = 2;
    public static string stockName = "±¸±Û";
    public static float price = 3000f;
    public static List<int> stockValue = new List<int> { 2780, 2850, 2900, 2860, 2920 };
    protected float changeRange;
    protected bool isIncrease;
    protected bool isDecrease;
}
