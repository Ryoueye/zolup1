using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap9 : MonoBehaviour {
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.transform.position = new Vector3(-66.91f, 4.5f ,-57.75f);
        }
    }
}
