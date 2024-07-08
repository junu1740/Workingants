
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingSystem : MonoBehaviour
{
    private float[] bestScore = new float[5];
    private string[] bestName = new string[5];

    public Text RankNameText;
    public Text RankScoreText;
    public Text[] RankNameTexts;
    public Text[] RankScoreTexts;


    // ���ο� ���� ���� �� ��ŷ ������Ʈ
    void ScoreSet(float currentscore, string currentname)
    {
        // ���� �÷��̾��� �ְ� ���� ������Ʈ
        PlayerPrefs.SetString("currentName", currentname);
        PlayerPrefs.SetFloat("currentScore", currentscore);

        float tmpScore = 0f;
        string tmpName = "";

        // ����� �ְ� ������� ���Ͽ� ���ο� ������ ����
        for (int i = 0; i < 5; i++)
        {
            bestScore[i] = PlayerPrefs.GetFloat(i + "BestScore");
            bestName[i] = PlayerPrefs.GetString(i + "BestName");

            while (bestScore[i] < currentscore)
            {
                tmpScore = bestScore[i];
                tmpName = bestName[i];
                bestScore[i] = currentscore;
                bestName[i] = currentname;

                PlayerPrefs.SetFloat(i + "BestScore", currentscore);
                PlayerPrefs.SetString(i + "BestName", currentname);

                currentscore = tmpScore;
                currentname = tmpName;
            }
        }
        Debug.Log("a");

        // ������Ʈ�� �ְ� �������� �ٽ� ����
        for (int i = 0; i < 5; i++)
        {
            PlayerPrefs.SetFloat(i + "BestScore", bestScore[i]);
            PlayerPrefs.SetString(i + "BestName", bestName[i]);
        }
    }
    private void Update()
    {
        // ���� �÷��̾��� ��ŷ ǥ��
        RankNameText.text = PlayerPrefs.GetString("currentName");
        RankScoreText.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("currentScore"));
        Debug.Log("bv");
        // ����� �ְ� �������� �����ͼ� ȭ�鿡 ǥ��
        for (int i = 0; i < 5; i++)
        {
            bestScore[i] = PlayerPrefs.GetFloat(i + "BestScore");
            RankScoreTexts[i].text = string.Format("{0:N2}", bestScore[i]);

            bestName[i] = PlayerPrefs.GetString(i + "BestName");
            RankNameTexts[i].text = bestName[i];

            // ���� �÷��̾��� ������ ���Ͽ� ������ ���� ����
            if (RankScoreText.text == RankScoreTexts[i].text)
            {
                Color rankColor = new Color(1f, 0.88f, 0f); // Yellow color
                RankScoreTexts[i].color = rankColor;
                RankNameTexts[i].color = rankColor;
            }
            else
            {
                // �⺻ �������� ����
                RankScoreTexts[i].color = Color.white;
                RankNameTexts[i].color = Color.white;
            }
        }
    }
}


