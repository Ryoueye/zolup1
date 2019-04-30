using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potal : MonoBehaviour {

    public float speed = 30.0f;
    private void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
