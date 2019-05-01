using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gomain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public void ButtonClick1()
    {
        SceneManager.LoadScene("main1");
        Time.timeScale = 1;
    }
}
