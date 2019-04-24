using UnityEngine;

public class trap2_1 : MonoBehaviour {
    public GameObject obj;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "trap2_1")
        {
            Instantiate(obj, new Vector3(-67, 2.3f, -57.46f), Quaternion.identity);
        }
    }
}
