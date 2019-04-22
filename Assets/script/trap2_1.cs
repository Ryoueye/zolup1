using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap2_1 : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "trap2")
        {
            col.transform.position = new Vector3(-67f, 0.5f, -59f);
        }
    }
}
