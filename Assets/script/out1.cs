using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class out1 : MonoBehaviour {

    void OnTriggerEnter(Collider co1)
    {
        if (co1.gameObject.tag == "Player")
        {
            Application.LoadLevel(3);
        }
    }
}
