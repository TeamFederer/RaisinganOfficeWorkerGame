using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portfoilo : MonoBehaviour
{
    // 1�� ~ 100��
    public static int PortfoiloScore = 0;

    // �����
    public static int PortfoiloScoreRise = 1;

    // 1���� �ʿ��� ��
    public static int PortfoiloScoreUpgradeMoney = 0;

    public void PortfoiloScoreUpgrade()
    {
        if (PortfoiloScore < 100 && Money.money >= PortfoiloScoreUpgradeMoney)
        {
            Money.money -= PortfoiloScoreUpgradeMoney;
            PortfoiloScore += PortfoiloScoreRise;
            ScrollbarHandler.ClickSpecUpButton();
        }
    }
}
