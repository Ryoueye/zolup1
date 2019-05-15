using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbody : MonoBehaviour {
    Rigidbody m_Rigidbody;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
    }
}
