using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Income : MonoBehaviour
{
    public static int income = 0;
    private float updateTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        updateTime += Time.deltaTime;
        if(updateTime >= 1)
        {
            updateTime = 0;
            GetComponent<Text>().text = "연봉: " + income.ToString();
        }

    }
}
