using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Stock
{
    public int level;
    public int hp;
    public int attack;
}

[Serializable]
public class StockData
{
    public List<Stock> stocks = new List<Stock>();
}

public class DataManager
{

    public void Init()
    {
        TextAsset textAsset = Managers.Resource.Load<TextAsset>($"Data/StockData");
        StockData _data = JsonUtility.FromJson<StockData>(textAsset.text);

    }
}
