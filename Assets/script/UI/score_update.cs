using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class score_update : MonoBehaviour {

    Text score;
	void Awake()
    {
        score = GetComponent<Text>();
    }
	
	void Update () {
        score.text = "Score: " + score_manager.Score.ToString();
	}
    
}
