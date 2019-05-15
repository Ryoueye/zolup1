using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour {
    public AudioClip[] shotSound = new AudioClip[1];

    //오디오 소스는 음악 재생기계 
    AudioSource Radio;

    void start()
    {
        Radio = GetComponent<AudioSource>();
        Radio.loop = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
           // Radio.Play(shotSound[0]);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            //일시정지 
            //Radio.Pause() 
            //정지 
            Radio.Stop();
        }
    }
}
