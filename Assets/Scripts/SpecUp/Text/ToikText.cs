using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToikText : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "토익공부\n" + Toik.ToikScore + "점";
    }
}
