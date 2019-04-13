using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {

    public float speed = 10.0f;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            score_manager.Score += 100;
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        transform.Rotate(Vector3.down * speed * Time.deltaTime);
    }
}
