using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal1 : MonoBehaviour {

    void OnTriggerEnter(Collider co1)
    {
        if (co1.gameObject.tag == "Player")
        {
            Application.LoadLevel(0);
        }
    }

}
