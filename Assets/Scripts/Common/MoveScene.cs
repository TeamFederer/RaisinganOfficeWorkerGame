using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MoveScene : MonoBehaviour
{
    public void MoveMainScene()
    {
        Debug.Log("main click");
        SceneManager.LoadScene("SampleScene");
    }

    public void MoveSpecUpScene()
    {
        Debug.Log("spec up click");
        SceneManager.LoadScene("SpecUpScene");
    }

    public void MoveStockScene()
    {
        Debug.Log("stock click");
        SceneManager.LoadScene("StockScene");
    }

    public void MoveCompanyScene()
    {
        Debug.Log("company click");
        SceneManager.LoadScene("CompanyScene");
    }
}
