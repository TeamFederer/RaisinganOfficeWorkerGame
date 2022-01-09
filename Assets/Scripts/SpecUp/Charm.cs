using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charm : MonoBehaviour
{
    // 1Á¡ ~ 100Á¡
    public static int CharmScore = 0;

    // »ó½ÂÆø
    public static int CharmScoreRise = 1;

    // 1Á¡´ç ÇÊ¿äÇÑ µ·
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
