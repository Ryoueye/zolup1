using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodyoff : MonoBehaviour {
    Rigidbody m_Rigidbody;

    public GameObject obj;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            m_Rigidbody = GetComponent<Rigidbody>();
            m_Rigidbody.constraints = RigidbodyConstraints.None;
        }
    }
}
