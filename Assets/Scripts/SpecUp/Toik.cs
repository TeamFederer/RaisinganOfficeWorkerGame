using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toik : MonoBehaviour
{
    //0�� ~ 999��
    public static int ToikScore = 0;

    //�����
    public static int ToikScoreRise = 1;

    //��������� �ʿ��� ��
    public static int ToikScoreUpgradeMoney = 0;

    public void ToikScoreUpgrade()
    {
        if(ToikScore < 1000 && Money.money >= ToikScoreUpgradeMoney)
        {
            Money.money -= ToikScoreUpgradeMoney;
            ToikScore += ToikScoreRise;
            ScrollbarHandler.ClickSpecUpButton();
        }
    }
}
