using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potal1 : MonoBehaviour {

    public float speed = 30.0f;
    private void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
