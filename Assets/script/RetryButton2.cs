using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton2 : MonoBehaviour {

    public void ButtonClick1()
    {

        SceneManager.LoadScene("tutorial");
        Time.timeScale = 1;
    }
}
