using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Out2 : MonoBehaviour {
	void OnTriggerEnter(Collider co1)
	{
		if (co1.gameObject.tag == "Player") {
            SceneManager.LoadScene("GamePlay2");
        }
	}

}
