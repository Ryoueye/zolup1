using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
        public void ButtonClick1()
        {

            SceneManager.LoadScene("loding1");
            Time.timeScale = 1;
    }
}


