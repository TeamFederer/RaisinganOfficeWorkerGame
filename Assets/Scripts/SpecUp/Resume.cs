using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    // 1�� ~ 100��
    public static int ResumeScore = 0;

    // �����
    public static int ResumeScoreRise = 1;

    // 1���� �ʿ��� ��
    public static int ResumeScoreUpgradeMoney = 0;

    public void ResumeScoreUpgrade()
    {
        if (ResumeScore < 100 && Money.money >= ResumeScoreUpgradeMoney)
        {
            Money.money -= ResumeScoreUpgradeMoney;
            ResumeScore += ResumeScoreRise;
            ScrollbarHandler.ClickSpecUpButton();
        }
    }
}
