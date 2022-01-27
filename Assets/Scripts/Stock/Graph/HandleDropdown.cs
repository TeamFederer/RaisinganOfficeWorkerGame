using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleDropdown : MonoBehaviour
{
    public Dropdown dropdown;
    public void selectedDropdown()
    {

        //stock = GameObject.Find("CurrentStock").GetComponent<CurrentStock>();

        switch (dropdown.value)
        {
            case 0:
                CurrentStock.stock_id = 0;
                CurrentStock.stockName = "삼성";
                CurrentStock.price = 50000;
                CurrentStock.stockValue = new List<int> { 10, 100, 1000, 10000, 100000 };
                break;
            case 1:
                CurrentStock.stock_id = 1;
                CurrentStock.stockName = "테슬라";
                CurrentStock.price = 1400;
                CurrentStock.stockValue = new List<int> { 1245, 1100, 1020, 1210, 1350 };
                break;
            case 2:
                CurrentStock.stock_id = 2;
                CurrentStock.stockName = "구글";
                CurrentStock.price = 3000;
                CurrentStock.stockValue = new List<int> { 2780, 2850, 2900, 2860, 2920 };
                break;
        }
    }
}
