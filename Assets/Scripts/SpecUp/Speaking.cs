using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speaking : MonoBehaviour
{
    // 1Á¡ ~ 100Á¡ 
    public static int SpeakingScore = 0;

    // »ó½ÂÆø
    public static int SpeakingScoreRise = 1;

    // 1Á¡´ç ÇÊ¿äÇÑ µ·
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
