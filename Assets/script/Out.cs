using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Out : MonoBehaviour {
	void OnTriggerEnter(Collider co1)
	{
		if (co1.gameObject.tag == "Player") {
            SceneManager.LoadScene("tutorial");
        }
	}

}
