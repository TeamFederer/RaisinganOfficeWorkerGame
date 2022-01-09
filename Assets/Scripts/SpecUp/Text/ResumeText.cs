using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResumeText : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = "자기소개서\n" + Resume.ResumeScore + "점";
    }
}
