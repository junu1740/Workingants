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
        // ���� �÷��̾��� �ְ� ���� ������Ʈ
        PlayerPrefs.SetString("Name", currentname);
        PlayerPrefs.SetFloat("Score", currentscore);

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

        // ������Ʈ�� �ְ� �������� �ٽ� ����
        for (int i = 0; i < 5; i++)
        {
            PlayerPrefs.SetFloat(i + "BestScore", bestScore[i]);
            PlayerPrefs.SetString(i + "BestName", bestName[i]);
        }
    }
}
