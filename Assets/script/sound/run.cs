using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour {
    public AudioClip[] shotSound = new AudioClip[1];

     
    AudioSource[] Radio = new AudioSource[2];

    void Start()
    {
        Radio[0] = gameObject.AddComponent<AudioSource>() as AudioSource;
        Radio[1] = gameObject.AddComponent<AudioSource>() as AudioSource;
        Radio[1].clip = shotSound[0];
        Radio[1].loop = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Radio[1].Play();
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            //일시정지 
            //Radio.Pause() 
            //정지 
            Radio[1].Stop();
        }
    }
}
