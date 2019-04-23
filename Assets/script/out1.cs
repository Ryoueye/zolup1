using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Out1 : MonoBehaviour {

    void OnTriggerEnter(Collider co1)
    {
        if (co1.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("G.O 1");
        }
    }
}
