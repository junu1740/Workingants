
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


    // 새로운 점수 설정 및 랭킹 업데이트
    void ScoreSet(float currentscore, string currentname)
    {
        // 현재 플레이어의 최고 점수 업데이트
        PlayerPrefs.SetString("currentName", currentname);
        PlayerPrefs.SetFloat("currentScore", currentscore);

        float tmpScore = 0f;
        string tmpName = "";

        // 저장된 최고 점수들과 비교하여 새로운 점수를 삽입
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

        // 업데이트된 최고 점수들을 다시 저장
        for (int i = 0; i < 5; i++)
        {
            PlayerPrefs.SetFloat(i + "BestScore", bestScore[i]);
            PlayerPrefs.SetString(i + "BestName", bestName[i]);
        }
    }
    private void Update()
    {
        // 현재 플레이어의 랭킹 표시
        RankNameText.text = PlayerPrefs.GetString("currentName");
        RankScoreText.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("currentScore"));
        Debug.Log("bv");
        // 저장된 최고 점수들을 가져와서 화면에 표시
        for (int i = 0; i < 5; i++)
        {
            bestScore[i] = PlayerPrefs.GetFloat(i + "BestScore");
            RankScoreTexts[i].text = string.Format("{0:N2}", bestScore[i]);

            bestName[i] = PlayerPrefs.GetString(i + "BestName");
            RankNameTexts[i].text = bestName[i];

            // 현재 플레이어의 점수와 비교하여 같으면 색상 변경
            if (RankScoreText.text == RankScoreTexts[i].text)
            {
                Color rankColor = new Color(1f, 0.88f, 0f); // Yellow color
                RankScoreTexts[i].color = rankColor;
                RankNameTexts[i].color = rankColor;
            }
            else
            {
                // 기본 색상으로 변경
                RankScoreTexts[i].color = Color.white;
                RankNameTexts[i].color = Color.white;
            }
        }
    }
}


