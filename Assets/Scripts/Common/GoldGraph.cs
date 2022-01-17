using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GoldGraph : MonoBehaviour
{
    public int SAMPLE_RATE = 10;
    // ���� ���� Ƚ���̴�. const�� �ұ��ϴ� �׽�Ʈ�� ���� �ϴ� public�ʵ�� ����
    public GameObject Dot;
    // ������ ���� �� ������
    public Transform DotGroup;

    // ������ ���� �ڽ����� �� �θ� ������Ʈ�̴�.
    // ������ ��Ƴ��� �Ͱ� ���� ���� �׷����� ������ �ٲٱ⿡ ���ϴ�.
    public Color BlueTeamColor;   // ����� ����
    public Color PurpleTeamColor; // ������ ����

    public RectTransform GraphArea;
    // �׷��� ���̰� �ػ󵵿� ���� �޶����Ƿ�.. �޾ƿ� �� �߰�

    private float graph_Width;
    private float graph_Height;

    private RectTransform labelTemplateX;
    private RectTransform labelTemplateY;



    // ����, ���� ������ ���� �߰�
    Dictionary<int, int[]> AllTeamTotalGold = new Dictionary<int, int[]> { };



    void Start()
    {
        labelTemplateX = GraphArea.Find("LabelTemplateX").GetComponent<RectTransform>();
        labelTemplateY = GraphArea.Find("LabelTemplateY").GetComponent<RectTransform>();

        // ---
        // AllTeamTotalGold Setting...
        var rand = new System.Random();
        int BlueTeamGold = 0, PurpleTeamGold = 0;
        for (int time = 0; time < 100; time++)
        {
            BlueTeamGold = BlueTeamGold + rand.Next(0, 1000);
            PurpleTeamGold = PurpleTeamGold + rand.Next(0, 1000);
            AllTeamTotalGold.Add(time, new[] { BlueTeamGold, PurpleTeamGold });
        }
        // ---

        graph_Width = GraphArea.rect.width;
        graph_Height = GraphArea.rect.height;
        // GraphArea�� ���� ���ΰ��� �����´�.

        DrawGoldGraph();
    }

    public Transform LineGroup;
    public GameObject Line;
    public GameObject MaskPanel;

    private void DrawGoldGraph()
    {
        float startPosition = -graph_Width / 2;
        // �׷��� ������ ���� / 2�� -�� ���̸� ������ġ�� �ȴ�.

        float maxYPosition = graph_Height / 2;
        // �׷��� ������ ���� / 2 => ���� ���� �ִ� ����

        // ---
        // ���� �÷��� ���� �� ����, �ִ밪 ����...(������)
        var comparisonValue = new Dictionary<int, int>();

        foreach (var pair in AllTeamTotalGold)
            comparisonValue.Add(pair.Key, pair.Value[0] - pair.Value[1]);
        // ������ ��� ���� ���� +�� Blue���� �켼, -�� Purple���� �켼

        float MaxValue = comparisonValue.Max(x => Mathf.Abs(x.Value));
        // ---

        Vector2 prevDotPos = Vector2.zero;

        for (int i = 0; i < SAMPLE_RATE; i++)
        {
            // �� ������Ʈ ���� �� �θ� ����, �� ������Ʈ ��������
            GameObject dot = Instantiate(Dot, DotGroup, true);
            dot.transform.localScale = Vector3.one;

            RectTransform dotRT = dot.GetComponent<RectTransform>();
            Image dotImage = dot.GetComponent<Image>();
            


            int tick = SAMPLE_RATE - 1 == i ? AllTeamTotalGold.Count - 1 : AllTeamTotalGold.Count / (SAMPLE_RATE - 1) * i;
            // �� ���ð� / ���ø��� ���� ������ ���� ���� ����������
            // ������ ��� ������ ���� ������ �˰�;� ��� ���� �ð��� ���� ������

            float yPos = comparisonValue[tick] / MaxValue;
            // tick�ð����� ������ / �������ִ밪 = -1.0f ~ 1.0f

            //dotImage.color = yPos >= 0f ? Color.red : Color.blue;
            dotImage.color = yPos >= 0f ? BlueTeamColor : PurpleTeamColor;

            // �� ����� ���� ������ 0�̿��� ���� BlueTeam������ �ϰ� �ȴ�.
            // �̰͵� �����ϰ� 0�϶��� �߸������� �ϰڴٸ� �ٲٸ� �ȴ�.

            dotRT.anchoredPosition = new Vector2(startPosition + (graph_Width / (SAMPLE_RATE - 1) * i), maxYPosition * yPos);
            // ���δ� startPosition���� �� �������� �þ�� ������������ ������ �Ͽ���
            // ���δ� ����/�����ִ밪�� ���� ���� ���� �ִ� ���̿��� ������ �°� ������ �Ͽ���.

            RectTransform labelX = Instantiate(labelTemplateX);
            labelX.SetParent(GraphArea);
            labelX.gameObject.SetActive(true);
            labelX.anchoredPosition = new Vector2(startPosition + (graph_Width / (SAMPLE_RATE - 1) * i) + 350, -7f);
            //labelX.GetComponent<Text>().text = (Mathf.Round(startPosition + (graph_Width / (SAMPLE_RATE - 1) * i))).ToString();
            labelX.GetComponent<Text>().text = (i + 1).ToString();

            RectTransform labelY = Instantiate(labelTemplateY);
            labelY.SetParent(GraphArea);
            labelY.gameObject.SetActive(true);
            labelY.anchoredPosition = new Vector2(-7f, maxYPosition * yPos + 150);
            //labelX.GetComponent<Text>().text = (Mathf.Round(startPosition + (graph_Width / (SAMPLE_RATE - 1) * i))).ToString();
            labelY.GetComponent<Text>().text = Mathf.RoundToInt((maxYPosition * yPos + 150)).ToString();

            if (i == 0)
            {
                prevDotPos = dotRT.anchoredPosition;
                continue;
            }

            GameObject line = Instantiate(Line, LineGroup, true);
            line.transform.localScale = Vector3.one;

            RectTransform lineRT = line.GetComponent<RectTransform>();
            Image lineImage = line.GetComponent<Image>();

            float lineWidth = Vector2.Distance(prevDotPos, dotRT.anchoredPosition);
            float xPos = (prevDotPos.x + dotRT.anchoredPosition.x) / 2;
            yPos = (prevDotPos.y + dotRT.anchoredPosition.y) / 2;
            float yPosGap = (dotRT.anchoredPosition.y - prevDotPos.y);
            // �׸����� ����..

            lineImage.color = yPos >= 0f ? Color.red : Color.blue;

            Vector2 dir = (dotRT.anchoredPosition - prevDotPos).normalized;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            lineRT.anchoredPosition = new Vector2(xPos, yPos);
            lineRT.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, lineWidth);
            lineRT.localRotation = Quaternion.Euler(0f, 0f, angle);
            // �� �� ������ ������ tan�� �̿��Ͽ� ���Ѵ�.
            // atan�� �̿��� ���� ���� ���ϰ� Rad2Deg�� �̿��� ������ ������ ��ȯ���ش�.

            GameObject maskPanel = Instantiate(MaskPanel, Vector3.zero, Quaternion.identity);
            maskPanel.transform.SetParent(LineGroup);
            maskPanel.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            maskPanel.transform.SetParent(line.transform);
            // ����ũ �г� ����

            prevDotPos = dotRT.anchoredPosition;
            // ���� �� ��ǥ ������Ʈ
        }
    }
}
