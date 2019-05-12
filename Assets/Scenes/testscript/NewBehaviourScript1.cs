using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewBehaviourScript1 : MonoBehaviour {
    public GameObject obj;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        obj.transform.RotateAround(Vector3.zero, Vector3.up, 60 * Time.deltaTime);
      
    }
}
