using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charm : MonoBehaviour
{
    // 1�� ~ 100��
    public static int CharmScore = 0;

    // �����
    public static int CharmScoreRise = 1;

    // 1���� �ʿ��� ��
    public static int CharmScoreUpgradeMoney = 0;

    public void CharmScoreUpgrade()
    {
        if (CharmScore < 100 && Money.money >= CharmScoreUpgradeMoney)
        {
            Money.money -= CharmScoreUpgradeMoney;
            CharmScore += CharmScoreRise;
            ScrollbarHandler.ClickSpecUpButton();
        }
    }
}
