using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap1 : MonoBehaviour {
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.transform.position = new Vector3(-67.35f, 8.16f ,-72.2f);
        }
    }
}
