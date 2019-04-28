using UnityEngine;

public class trap2_4 : MonoBehaviour {
    public GameObject obj;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "trap2_4")
        {
            Instantiate(obj, new Vector3(-67.44f, 2.94f, 24f), Quaternion.identity);
        }
    }
}
