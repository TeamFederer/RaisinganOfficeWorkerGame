using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpeakingText : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = "ȭ��\n" + Speaking.SpeakingScore + "��";
    }
}
