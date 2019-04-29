using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap8 : MonoBehaviour {
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.transform.position = new Vector3(-67.14f, 8.16f ,-18.05f);
        }
    }
}
