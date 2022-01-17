using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stock : MonoBehaviour
{
    //이름, 가격, 변화폭, 상승주기, 하향주기
    public static int stock_id;
    public static string stockName;
    public static float price;
    public static List<int> stockValue;
    protected float changeRange;
    protected bool isIncrease;
    protected bool isDecrease;
}
