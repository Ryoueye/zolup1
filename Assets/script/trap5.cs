using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap5 : MonoBehaviour {
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.transform.position = new Vector3(-59.82f, 5.15f, -21.5f);
        }
    }
}
