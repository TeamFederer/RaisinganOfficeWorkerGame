using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int Money = 500000;
    public static int Income = 10000;
    public static Dictionary<string, int> PlayerStock = new Dictionary<string, int>() { { "삼성", 0 }, { "테슬라", 0 }, { "구글", 0 } };



    void Start()
    {
        
    }
}
