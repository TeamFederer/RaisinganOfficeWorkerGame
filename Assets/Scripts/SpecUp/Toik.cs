using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toik : MonoBehaviour
{
    //0Á¡ ~ 999Á¡
    public static int ToikScore = 0;

    //»ó½ÂÆø
    public static int ToikScoreRise = 1;

    //»ó½ÂÆø¸¶´Ù ÇÊ¿äÇÑ µ·
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
