using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsound : MonoBehaviour {

    public float speed = 10.0f;
    public AudioClip[] shotSound = new AudioClip[1];

    AudioSource Radio;

    void Start()
    {

        Radio = GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            
            Radio.PlayOneShot(shotSound[0]);
            Destroy(this.gameObject,0.5f);
        }
    }
    private void Update()
    {
        transform.Rotate(Vector3.down * speed * Time.deltaTime);
    }
}
