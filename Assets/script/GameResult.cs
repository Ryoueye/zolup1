using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameResult : MonoBehaviour {
	int highScore;

	public Text resultTime, bestTime;

	public GameObject parts;

	void Start()
	{
		if (PlayerPrefs.HasKey ("HightScore")) 
		{
			highScore = PlayerPrefs.GetInt ("HightScore");
		}

		else 
		{
			highScore = 999;
		}
	}

	void Update()
	{
		if (Goal.goal) {
			parts.SetActive (true);
			int result = Mathf.FloorToInt (Timer.time);
			resultTime.text = "ResultTime : " + result;
			bestTime.text = "BestTime : " + highScore;

			if (highScore > result) {
				PlayerPrefs.SetInt ("HightScore", result);
			}
		}
		Goal.goal = false;
	}
	public void OnRetry ()
	{
		Application.LoadLevel ("Main");
	}
}