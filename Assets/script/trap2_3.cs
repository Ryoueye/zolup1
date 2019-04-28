using UnityEngine;

public class trap2_3 : MonoBehaviour {
    public GameObject obj;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "trap2_3")
        {
            Instantiate(obj, new Vector3(-67.44f, 2.91f, 1.83f), Quaternion.identity);
        }
    }
}
