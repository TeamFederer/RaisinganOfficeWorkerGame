using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleDropdown : MonoBehaviour
{
    public Dropdown dropdown;
    public CurrentStock stock;
    public void selectedDropdown()
    {

        //stock = GameObject.Find("CurrentStock").GetComponent<CurrentStock>();

        switch (dropdown.value)
        {
            case 0:
                stock.SetCurrentStock(Stock_Samsung.stock_id,Stock_Samsung.stockName,Stock_Samsung.price,Stock_Samsung.stockValue);
                break;
            case 1:
                stock.SetCurrentStock(Stock_Tesla.stock_id,Stock_Tesla.stockName, Stock_Tesla.price, Stock_Tesla.stockValue);
                break;
            case 2:
                stock.SetCurrentStock(Stock_Google.stock_id,Stock_Google.stockName, Stock_Google.price, Stock_Google.stockValue);
                break;
        }
    }
}
