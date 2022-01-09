using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portfoilo : MonoBehaviour
{
    // 1Á¡ ~ 100°³
    public static int PortfoiloScore = 0;

    // »ó½ÂÆø
    public static int PortfoiloScoreRise = 1;

    // 1Á¡´ç ÇÊ¿äÇÑ µ·
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
