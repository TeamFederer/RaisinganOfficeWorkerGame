using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPlayerMoney : MonoBehaviour
{

    private int money;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        money = Money.money;
        GetComponent<Text>().text = "°¡Áøµ· : " + money;
    }
}
