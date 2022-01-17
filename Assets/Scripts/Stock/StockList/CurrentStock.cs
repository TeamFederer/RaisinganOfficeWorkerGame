using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentStock : MonoBehaviour
{
    public int stock_id;
    public string stockName;
    public float price;
    public List<int> stockValue;

    public void SetCurrentStock(int stock_id, string stockName, float price, List<int> stockValue)
    {
        this.stock_id = stock_id;
        this.stockName = stockName;
        this.price = price;
        this.stockValue = stockValue;
    }

    private void Start()
    {
        SetCurrentStock(Stock_Samsung.stock_id,Stock_Samsung.stockName,Stock_Samsung.price,Stock_Samsung.stockValue);
    }
}
