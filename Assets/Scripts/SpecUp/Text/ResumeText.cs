using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResumeText : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = "�ڱ�Ұ���\n" + Resume.ResumeScore + "��";
    }
}
