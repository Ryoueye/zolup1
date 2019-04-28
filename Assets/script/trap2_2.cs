using UnityEngine;

public class trap2_2 : MonoBehaviour {
    public GameObject obj;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "trap2_2")
        {
            Instantiate(obj, new Vector3(-67.4f, 1.2f, -3.94f), Quaternion.Euler(90,0,0));
        }
    }
}
