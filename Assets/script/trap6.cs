using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap6 : MonoBehaviour {
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.transform.position = new Vector3(-73.9f, 5.15f, -21.5f);
        }
    }
}
