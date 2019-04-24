using System;
using UnityEngine;

public class trap3 : MonoBehaviour {
    public GameObject obj;
    private void SetAcive(bool v)
    {
        throw new NotImplementedException();
    }
    void Start()
    {
        obj.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            obj.gameObject.SetActive(true);
            col.transform.position = new Vector3(-65.5f, 10,-50.5f);
        }
    }
}
