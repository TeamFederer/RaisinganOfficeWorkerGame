using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCurrentStockPrice : MonoBehaviour
{

    public CurrentStock stock;
    void Start()
    {
        
    }

    void Update()
    {
        GetComponent<Text>().text = "���簡�� : " + stock.price;
    }
}
