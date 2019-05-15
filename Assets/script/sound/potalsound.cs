using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potalsound : MonoBehaviour {

    public AudioClip[] shotSound = new AudioClip[1];

    //오디오 소스는 음악 재생기계 
    AudioSource Radio;

    void Start()
    {
        //오디오소스 컴포넌트 받아주세요. 
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
