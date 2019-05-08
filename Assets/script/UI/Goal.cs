using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	public static bool goal;
	void Start () {
		goal = false;
	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Player"){
			goal = true;
	}
}
}