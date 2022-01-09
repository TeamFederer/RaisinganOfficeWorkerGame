using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speaking : MonoBehaviour
{
    // 1�� ~ 100�� 
    public static int SpeakingScore = 0;

    // �����
    public static int SpeakingScoreRise = 1;

    // 1���� �ʿ��� ��
    public static int SpeakingScoreUpgradeMoney = 0;

    public void SpeakingScoreUpgrade()
    {
        if (SpeakingScore < 100 && Money.money >= SpeakingScoreUpgradeMoney)
        {
            Money.money -= SpeakingScoreUpgradeMoney;
            SpeakingScore += SpeakingScoreRise;
            ScrollbarHandler.ClickSpecUpButton();
        }
    }
}
