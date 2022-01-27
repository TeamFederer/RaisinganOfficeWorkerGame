using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyStock : MonoBehaviour
{

    public StockManager stockManger;
    public InputField input;

    void Start()
    {
    }

    public void clickBuyStockButton()
    {
        Debug.Log(input.text);
        bool IsBuy = stockManger.BuyStock(int.Parse(input.text));
        Debug.Log(IsBuy);
    }
}
