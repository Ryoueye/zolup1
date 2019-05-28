using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class rotation : MonoBehaviour {
    public GameObject obj;
    public GameObject obj1;
    // Use this for initialization
    void Start () {
        gameObject.GetComponent<rotation>().enabled = false;
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            gameObject.GetComponent<rotation>().enabled = true;
            obj1.gameObject.SetActive(false);

        }
    }
    // Update is called once per frame
    void Update () {

        if (obj.transform.eulerAngles.y < 180)
            obj.transform.Rotate(Vector3.up, 120 * Time.deltaTime);
      
    }
}
