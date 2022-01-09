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
        //������� �ϳ��� ��ư�� ������ �ൿ�� ��.
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
