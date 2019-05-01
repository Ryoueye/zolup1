using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour {
    public GameObject obj;
    private void SetAcive(bool v)
    {
        throw new NotImplementedException();
    }

    void Start()
    {
        obj.gameObject.SetActive(false);
    }

    void Update () {
        if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.Space))
        {
            obj.gameObject.SetActive(true);
                   
        }
        else
            obj.gameObject.SetActive(false);
    }
}
