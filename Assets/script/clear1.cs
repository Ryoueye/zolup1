using UnityEngine;
using UnityEngine.SceneManagement;

public class clear1 : MonoBehaviour
{

    public void ButtonClick1()
    {

        SceneManager.LoadScene("loding2");
        Time.timeScale = 1;
    }

}
