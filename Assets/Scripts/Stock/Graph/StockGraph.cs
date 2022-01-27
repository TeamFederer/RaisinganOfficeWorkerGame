using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class StockGraph : MonoBehaviour
{
    Dictionary<int, int> StockValue = new Dictionary<int, int> { };
    
    List<int> Stock = new List<int> { 10, 100, 1000, 10000, 100000 };

    public int prevStockId;

    public int SAMPLE_RATE = 10;
    public GameObject Dot;
    public Transform DotGroup;
    public Color DotColor;
    public RectTransform GraphArea;

    public Transform LineGroup;
    public GameObject Line;
    public GameObject MaskPanel;

    public Transform labelTemplateGroup;
    public RectTransform labelTemplateX;
    public RectTransform labelTemplateY;

    public Dropdown dropdown;

    private float graph_Width;
    private float graph_Height;
    private int StockAverage;

    void Start()
    {
        prevStockId = CurrentStock.stock_id;
        if(CurrentStock.stockValue.Count != 0)
        {
            Stock = CurrentStock.stockValue;
        }

        labelTemplateX = labelTemplateGroup.Find("labelTemplateX").GetComponent<RectTransform>();
        labelTemplateY = labelTemplateGroup.Find("labelTemplateY").GetComponent<RectTransform>();

        int sum = 0;

        StockValue.Clear();

        for (int i = 0; i < Stock.Count; i++)
        {
            StockValue.Add(i, Stock[i]);
            sum += Stock[i];
        }

        StockAverage = sum / Stock.Count;

        graph_Width = GraphArea.rect.width;
        graph_Height = GraphArea.rect.height;

        DrawStockGraph();

    }


    private void DrawStockGraph()
    {
        var comparisonValue = new Dictionary<int, int>();
        foreach (var pair in StockValue)
        {
            comparisonValue.Add(pair.Key, pair.Value - StockAverage);
        }

        float startPosition = -graph_Width / 2;
        float maxYPosition = graph_Height / 2;

        float MaxValue = comparisonValue.Max(x => Mathf.Abs(x.Value));

        Vector2 prevDotPos = Vector2.zero;

        for(int i = 0; i < SAMPLE_RATE; i++)
        {
            // ---
            // Á¡ Âï±â
            // ---

            GameObject dot = Instantiate(Dot, DotGroup, true);
            dot.transform.localScale = Vector3.one;

            RectTransform dotRT = dot.GetComponent<RectTransform>();
            Image dotImage = dot.GetComponent<Image>();

            int tick = i;

            float yPos = comparisonValue[tick] / MaxValue;

            dotImage.color = DotColor; 

            dotRT.anchoredPosition = new Vector2(startPosition + (graph_Width / (SAMPLE_RATE - 1) * i), maxYPosition * yPos);

            float xPosition = startPosition + (graph_Width / (SAMPLE_RATE - 1) * i) + graph_Width/2;
            float yPosition = maxYPosition * yPos + graph_Height/2;

            if(i == 0)
            {
                xPosition += 10f;
            }
            else if(i == SAMPLE_RATE - 1)
            {
                xPosition -= 15f;
            }


            // --- 
            // ¶óº§ Axis
            // ---

            RectTransform labelX = Instantiate(labelTemplateX);
            labelX.SetParent(labelTemplateGroup);
            labelX.gameObject.SetActive(true);
            labelX.anchoredPosition = new Vector2(xPosition, -10f);
            labelX.GetComponent<Text>().text = (i + 1).ToString() + "ÀÏ";

            RectTransform labelY = Instantiate(labelTemplateY);
            labelY.SetParent(labelTemplateGroup);
            labelY.gameObject.SetActive(true);
            labelY.anchoredPosition = new Vector2(0f, yPosition);
            labelY.GetComponent<Text>().text = Stock[i].ToString();

            // ---
            // ¼± Âï±â
            // --- 

            if (i == 0)
            {
                prevDotPos = dotRT.anchoredPosition;
                continue;
            }

            GameObject line = Instantiate(Line, LineGroup, true);
            line.transform.localScale = Vector3.one;

            RectTransform lineRT = line.GetComponent<RectTransform>();
            Image lineImage = line.GetComponent<Image>();

            //lineImage.color = yPos >= 0f ? Color.red : Color.blue;

            float lineWidth = Vector2.Distance(prevDotPos, dotRT.anchoredPosition);
            float xPos = (prevDotPos.x + dotRT.anchoredPosition.x) / 2;
            yPos = (prevDotPos.y + dotRT.anchoredPosition.y) / 2;

            Vector2 dir = (dotRT.anchoredPosition - prevDotPos).normalized;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            lineRT.anchoredPosition = new Vector2(xPos, yPos);
            lineRT.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, lineWidth);
            lineRT.localRotation = Quaternion.Euler(0f, 0f, angle);

            lineImage.color = dir.y >= 0f ? Color.red : Color.blue; 

            GameObject maskPanel = Instantiate(MaskPanel, Vector3.zero, Quaternion.identity);
            maskPanel.transform.SetParent(LineGroup);
            maskPanel.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            maskPanel.transform.SetParent(line.transform);

            prevDotPos = dotRT.anchoredPosition;

        }
    }

    private void RemoveGraph()
    {
        for (int i = 0; i < DotGroup.childCount; i++)
        {
            Destroy(DotGroup.GetChild(i).gameObject);
        }
        for (int i = 1; i < LineGroup.childCount; i++)
        {
            Destroy(LineGroup.GetChild(i).gameObject);
        }
        for (int i = 2; i < labelTemplateGroup.childCount; i++)
        {
            Destroy(labelTemplateGroup.GetChild(i).gameObject);
        }
    }


    private void Update()
    {
        if(prevStockId != CurrentStock.stock_id)
        {
            Debug.Log("stock change");
            RemoveGraph();
            Start();
            
        }
    }
}
