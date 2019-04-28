using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap4 : MonoBehaviour {
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.transform.position = new Vector3(-67.1f, 8.16f ,-31.85f);
        }
    }
}
