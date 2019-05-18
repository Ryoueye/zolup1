using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodyoff : MonoBehaviour {
    Rigidbody m_Rigidbody;

    public GameObject[] obj = new GameObject[100];

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            for (int i = 0; i< 101; i++)
           obj[i].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
           
        }
    }
}
