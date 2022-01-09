using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScrollbarHandler : MonoBehaviour
{
    public static bool IsButtonClick = false;
    public static Scrollbar scrollbar;
    public static void ClickSpecUpButton()
    {
        IsButtonClick = true;
    }

    void Start()
    {
        scrollbar = GetComponent<Scrollbar>();
    }

    void Update()
    {
        //스펙업중 하나의 버튼이 눌리면 행동을 함.
        if (IsButtonClick)
        {
            scrollbar.size += 0.01f;
            if(scrollbar.size == 1)
            {
                scrollbar.size = 0;
                IsButtonClick = false;
            }
        }
    }

}
