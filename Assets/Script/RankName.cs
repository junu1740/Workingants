using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RankName : MonoBehaviour
{
    public Text IDTxt;

    private float[] bestScore = new float[5];
    private string[] bestName = new string[5];

    public void Gamestart()
    {
        PlayerPrefs.SetString("Name",IDTxt.text);


        SceneManager.LoadScene("Main");
    }

    void ScoreSet(float currentscore, string currentname)
    {
        // 현재 플레이어의 최고 점수 업데이트
        PlayerPrefs.SetString("Name", currentname);
        PlayerPrefs.SetFloat("Score", currentscore);

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

        // 업데이트된 최고 점수들을 다시 저장
        for (int i = 0; i < 5; i++)
        {
            PlayerPrefs.SetFloat(i + "BestScore", bestScore[i]);
            PlayerPrefs.SetString(i + "BestName", bestName[i]);
        }
    }
}
