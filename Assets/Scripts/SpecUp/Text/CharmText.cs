using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharmText : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = "¸Å·Â\n" + Charm.CharmScore + "Á¡";
    }
}
