using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCurrentStockPrice : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        GetComponent<Text>().text = "���簡�� : " + CurrentStock.price;
    }
}
