using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap2 : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {   for (int i = 0; i < 101; i++)
            transform.position += new Vector3(0f,-0.1f,0f) * Time.deltaTime * 0.4f;
        }
    }
}

