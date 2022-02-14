using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stock_BuySell : Stock_Base
{
    enum Buttons
    {
        BuyButton,
        SellButton,
    }

    enum Texts
    {
        BuyButtonText,
        SellButtonText,
    }
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    public void Init()
    {
        Bind<Button>(typeof(Buttons));
        Bind<Text>(typeof(Texts));
        Button go_buy = GetButton((int)Buttons.BuyButton);
        Button go_sell = GetButton((int)Buttons.SellButton);
        Text buy_text = GetText((int)Texts.BuyButtonText);
        Text sell_text = GetText((int)Texts.SellButtonText);

        go_buy.onClick.AddListener(() => {
            int input;
            bool par = int.TryParse(buy_text.text, out input);
            if (par)
                Managers.Stock.BuyStock(input);
            else
                Debug.Log("Failed to Stock Buy Parse!");
        });
        go_sell.onClick.AddListener(() => {
            int input;
            bool par = int.TryParse(sell_text.text, out input);
            if (par)
                Managers.Stock.SellStock(input);
            else
                Debug.Log("Failed to Stock Sell Parse!");
        });

    }
}
