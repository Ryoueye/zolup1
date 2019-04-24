using System;
using UnityEngine;
public class optionOn : MonoBehaviour
{
    private bool isPause;

    private void SetAcive(bool v)
    {
        throw new NotImplementedException();
    }
    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
    }
        public void ButtonClick1()
        {
        gameObject.SetActive(true);
        Time.timeScale = 0;
        isPause = false;
    }
}