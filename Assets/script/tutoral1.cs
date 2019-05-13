using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutoral1 : MonoBehaviour {
    public GameObject obj;
    public GameObject obj1;
    public GameObject obj2;
    private void SetAcive(bool v)
    {
        throw new NotImplementedException();
    }
    // Use this for initialization
    void Start () {
        obj.gameObject.SetActive(false);
        obj1.gameObject.SetActive(false);
        obj2.gameObject.SetActive(false);
    }
	public void OnTriggerEnter(Collider co1)
    {
        if (co1.gameObject.tag == "Player")
            obj.gameObject.SetActive(true);
            obj1.gameObject.SetActive(true);
            obj2.gameObject.SetActive(true);
    }
    public void OnTriggerExit(Collider col)
    {
        obj.gameObject.SetActive(false);
        obj1.gameObject.SetActive(false);
        obj2.gameObject.SetActive(false);
    }
}
