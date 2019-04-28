using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    float rotSpeed = 1.0f; //ADD

    // Update is called once per frame

    void Update()
    {





        // 마우스 입력

        float MouseX = Input.GetAxis("Mouse X");



        transform.Rotate(Vector3.up * rotSpeed * MouseX);

    }
}
