using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PortfoiloText : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = "��Ʈ������\n" + Portfoilo.PortfoiloScore + "��";
    }
}
