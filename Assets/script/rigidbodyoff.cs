using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodyoff : MonoBehaviour {
    Rigidbody m_Rigidbody;

    public GameObject[] obj = new GameObject[100];
    public GameObject obj1;

    void Remove()
    {
        obj1.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Invoke("Remove", 1.5f);
            for (int i = 0; i< 101; i++)
           obj[i].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }
}
