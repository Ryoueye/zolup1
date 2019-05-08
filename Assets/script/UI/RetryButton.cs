using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour {

    public void ButtonClick1()
    {

        SceneManager.LoadScene("GamePlay1");
        Time.timeScale = 1;
    }
}
