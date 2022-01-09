using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PortfoiloText : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = "포트폴리오\n" + Portfoilo.PortfoiloScore + "점";
    }
}
