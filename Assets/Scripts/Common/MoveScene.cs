using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MoveScene : MonoBehaviour
{
    public void MoveMainScene()
    {
        Debug.Log("click");
        SceneManager.LoadScene("SampleScene");
    }

    public void MoveSpecUpScene()
    {
        Debug.Log("click");
        SceneManager.LoadScene("SpecUpScene");
    }

    public void MoveStockScene()
    {
        SceneManager.LoadScene("StockScene");
    }
}
