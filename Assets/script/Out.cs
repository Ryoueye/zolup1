using UnityEngine;
using System.Collections;

public class Out : MonoBehaviour {
	void OnTriggerEnter(Collider co1)
	{
		if (co1.gameObject.tag == "Player") {
			Application.LoadLevel (2);
		}
	}

}
