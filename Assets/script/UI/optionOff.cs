using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionOff : MonoBehaviour
{
    private bool isPause;
    private void SetAcive(bool v)
    {
        throw new NotImplementedException();
    }
        public void ButtonClick1()
        {
            gameObject.SetActive(false);
        Time.timeScale = 1;
        isPause = true;
        }
}