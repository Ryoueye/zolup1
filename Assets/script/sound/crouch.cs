using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouch : MonoBehaviour
{
//오디오 클립은 음악 소스
    public AudioClip[] shotSound = new AudioClip[3];

    //오디오 소스는 음악 재생기계 
    AudioSource Radio;

    void Start()
    {
        //오디오소스 컴포넌트 받아주세요. 
        Radio = GetComponent<AudioSource>();
       
    }

    void Update()
    {
        //콘솔 키 입력시 재생 
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (Radio.isPlaying) return;
            Radio.PlayOneShot(shotSound[0]);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (Radio.isPlaying) return;
            Radio.loop = true;
            Radio.PlayOneShot(shotSound[1]);
            
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Radio.isPlaying) return;
            Radio.PlayOneShot(shotSound[2]);
        }
    }

}
