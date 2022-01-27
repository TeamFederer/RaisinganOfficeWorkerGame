using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockManager : MonoBehaviour
{
    public static StockManager instance = null;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }
    }

    public bool BuyStock(int cnt)
    {
        Debug.Log(Player.Money + " " + Player.Income + CurrentStock.price * cnt);
        if(Player.Money >= CurrentStock.price * cnt)
        {
            Debug.Log("dd");
            Player.PlayerStock[CurrentStock.stockName] += cnt;
            Player.Money -= CurrentStock.price * cnt;
            foreach(var item in Player.PlayerStock) 
            {
                Debug.Log(item.Key + " " + item.Value);
            }
            return true;
        }
        return false;
    }

}
