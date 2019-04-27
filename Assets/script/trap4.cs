using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap4 : MonoBehaviour {
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.transform.position = new Vector3(-6+.35f, 7 ,-31.5f);
        }
    }
}
