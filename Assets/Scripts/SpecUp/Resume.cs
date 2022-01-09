using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    // 1Á¡ ~ 100Á¡
    public static int ResumeScore = 0;

    // »ó½ÂÆø
    public static int ResumeScoreRise = 1;

    // 1Á¡´ç ÇÊ¿äÇÑ µ·
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
