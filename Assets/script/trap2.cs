using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap2 : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            transform.Translate(new Vector3(0,-15,0) * Time.deltaTime);
        }
    }
}

