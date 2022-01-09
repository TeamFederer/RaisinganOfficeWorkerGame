using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    //돈
    public static int money = 0;

    //연봉에 비례해 일하기 버튼을 누르면 올라가는 돈의 양
    public int moneyRise = 1 * Income.income;

}
