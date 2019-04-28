using UnityEngine;
using System.Collections;

public class followcam : MonoBehaviour {

    public Transform target;
    public float dist = 7.0f;
    public float Edist = 1f;
    public float heigth = 4.2f;
    public float Eheigth = 1.5f;
    public float smoothRotate = 10.0f;
    
    private Transform tr;

	void Start () {
        tr = GetComponent<Transform>();
	}
	
	void LateUpdate () {
        float currYangle = Mathf.LerpAngle(tr.eulerAngles.y, target.eulerAngles.y, smoothRotate * Time.deltaTime);

        Quaternion rot = Quaternion.Euler(0, currYangle, 0);

        tr.position = target.position - (rot * Vector3.forward * dist) + (Vector3.up * heigth);

        tr.LookAt(target);

        if (Input.GetKey(KeyCode.E))
        {
            tr.position = target.position - (rot * Vector3.forward * Edist) + (Vector3.up * Eheigth);
        }
    }
}
