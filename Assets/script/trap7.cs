using UnityEngine;

public class trap7 : MonoBehaviour {
    public GameObject obj;
    public GameObject obj1;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "trap7_tag")
        {
            Instantiate(obj, new Vector3(-66.75f, 0.5f, 11.33f), Quaternion.identity);
            Destroy(obj1);
        }
    }
}
