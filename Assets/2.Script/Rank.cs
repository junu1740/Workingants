using UnityEngine;
using UnityEngine.UI;

public class RankingSystem : MonoBehaviour
{
    public Text BestScoreText;
    public Text BestNameText;
    public Text CurrentScoreText;
    public Text CurrentNameText;

    
    private void OnEnable()
    {

        

        float bestScore = PlayerPrefs.GetFloat("BestScore", Mathf.Infinity);
        string bestName = PlayerPrefs.GetString("BestName", "zlÁ¸ÅÂÈñ");

        float currentScore = TimerManager.instance.Time;
        string currentName = PlayerPrefs.GetString("Name", "ÁÖ´©Â¯Â¯");

        CurrentScoreText.text = currentScore.ToString();
        CurrentNameText.text = currentName;

        if (currentScore < bestScore)
        {
            bestScore = currentScore;
            bestName = currentName;

            PlayerPrefs.SetFloat("BestScore", bestScore);
            PlayerPrefs.SetString("BestName", bestName);
        }

        BestScoreText.text = bestScore.ToString();
        BestNameText.text = bestName;
    }
}


