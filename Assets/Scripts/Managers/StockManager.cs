using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockManager
{
    public bool BuyStock(int cnt)
    {
        Debug.Log($"���� : {cnt}, BuyButtonClick!");

        return false;
    }

    public bool SellStock(int cnt)
    {
        Debug.Log($"���� : {cnt}, SellButtonClick!");
        return false;
    }

}
