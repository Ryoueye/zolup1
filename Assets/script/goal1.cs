using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal1 : MonoBehaviour {

    void OnTriggerEnter(Collider co1)
    {
        if (co1.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("main1");
            Time.timeScale = 1;
        }
    }

}
