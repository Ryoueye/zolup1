using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouch : MonoBehaviour
{
//오디오 클립은 음악 소스
    public AudioClip[] shotSound = new AudioClip[2];

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
        if (Input.GetKeyDown(KeyCode.E))
        {
            //볼륨은 매니저로 전체 조절중입니다. 
            Radio.PlayOneShot(shotSound[0]);
        }
    }

}
