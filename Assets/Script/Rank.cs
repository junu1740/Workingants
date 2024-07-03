
    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingSystem : MonoBehaviour
{
    private float[] bestScore = new float[5];
    private string[] bestName = new string[5];

    public Text RankName;
    public Text RankScore;


    private void Update()
    {
        RankName.text = PlayerPrefs.GetString("PlayerName");
        RankScore.text = string.Format("{0:N3}cm", PlayerPrefs.GetFloat("PlayerScore"));

        for (int i = 0; i < 5; i++)
        {
           
        }
    }




    void ScoreSet(float score, string name)
    {
        PlayerPrefs.SetString("PlayerName", name);
        PlayerPrefs.SetFloat("PlayerScore", score);

        float tmpscore = 0f;
        string tmpname = "";

        for (int i = 0; i < 5; i++)
        {
            bestScore[i] = PlayerPrefs.GetFloat(i + "BestScore");
            bestName[i] = PlayerPrefs.GetString(i + "BestName");

            while (bestScore[i] < score)
            {
                tmpscore = bestScore[i];
                tmpname = bestName[i];
                bestScore[i] = score;
                bestName[i] = name;

                PlayerPrefs.SetFloat(i + "BestScore", score);
                PlayerPrefs.SetString(i.ToString() + "BestName", name);

                score = tmpscore;
                name = tmpname;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            PlayerPrefs.SetFloat(i + "BestScore", bestScore[i]);
            PlayerPrefs.SetString(i.ToString() + "BestName", bestName[i]);
        }


    }
}


