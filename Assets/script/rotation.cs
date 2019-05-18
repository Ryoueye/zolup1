using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class rotation : MonoBehaviour {
    public GameObject obj;
    // Use this for initialization
    void Start () {
        gameObject.GetComponent<rotation>().enabled = false;
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            gameObject.GetComponent<rotation>().enabled = true;

        }
    }
    // Update is called once per frame
    void Update () {

        gameObject.GetComponent<rotation>().enabled = true;

        if (transform.eulerAngles.y < 180)
            obj.transform.RotateAround(Vector3.zero, Vector3.up, 60 * Time.deltaTime);
      
    }
}
