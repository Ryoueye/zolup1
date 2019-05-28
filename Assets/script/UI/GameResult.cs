using UnityEngine;
using UnityEngine.UI;
public class GameResult : MonoBehaviour {
	int highTime;
    int highScore;
   

    public Text resultTime, bestTime, resultScore, bestScore;

    public GameObject parts;

  
    void Stop()
    {
        Time.timeScale = 0;
    }

    void Result()
    {
        parts.SetActive(true);
    }

	void Start()
	{
        

        if (PlayerPrefs.HasKey ("HightTime")) 
		{
			highTime = PlayerPrefs.GetInt ("HightTime");
		}

		else 
		{
			highTime = 999;
		}

        if (PlayerPrefs.HasKey("HightScore"))
        {
            highScore = PlayerPrefs.GetInt("HightScore");
        }

        else
        {
            highScore = 0;
        }
    }

	void Update()
	{

		if (Goal.goal) {

            int timeresult = Mathf.FloorToInt(Timer.time);
            int scoreresult = score_manager.Score;

            if (highTime > timeresult)
            {
                PlayerPrefs.SetInt("HightTime", timeresult);
            }
            if (highScore < scoreresult)
            {
                PlayerPrefs.SetInt("HightScore", scoreresult);
            }

            Invoke("Result", 5f);

            resultTime.text = "ResultTime : " + timeresult;
			bestTime.text = "BestTime : " + highTime;
            resultScore.text = "ResultScore : " + scoreresult;
            bestScore.text = "BestScore : " + highScore;

            Invoke("Stop", 5f);






        }
		Goal.goal = false;
	}
}