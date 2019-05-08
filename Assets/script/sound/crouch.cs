using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouch : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip bgm;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = bgm; //오디오에 bgm이라는 파일 연결

        audioSource.volume = 1.0f; //0.0f ~ 1.0f사이의 숫자로 볼륨을 조절
        audioSource.loop = false; //반복 여부
        audioSource.mute = false; //오디오 음소거
        if (Input.GetKey(KeyCode.E))
            audioSource.Play(); //오디오 재생

        audioSource.priority = 0;
        //씬안에 모든 오디오소스중 현재 오디오 소스의 우선순위를 정한다.
        // 0 : 최우선, 256 : 최하, 128 : 기본값
    }
    
}
