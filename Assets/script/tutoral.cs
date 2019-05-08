using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutoral : MonoBehaviour {
    public GameObject obj;
    private void SetAcive(bool v)
    {
        throw new NotImplementedException();
    }
    // Use this for initialization
    void Start () {
        obj.gameObject.SetActive(false);
    }
	public void OnTriggerEnter(Collider co1)
    {
        if (co1.gameObject.tag == "Player")
            obj.gameObject.SetActive(true);
    }
    public void OnTriggerExit(Collider col)
    {
        obj.gameObject.SetActive(false);
    }
}
