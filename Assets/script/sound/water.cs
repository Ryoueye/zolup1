using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour {

    public AudioClip[] shotSound = new AudioClip[1];

   
    AudioSource Radio;

    void Start()
    {
         
        Radio = GetComponent<AudioSource>();

    }

   
        void OnTriggerEnter(Collider co1)
    {
        if (co1.gameObject.tag == "Player")
        {
            Radio.PlayOneShot(shotSound[0]);
        }
    }
}
