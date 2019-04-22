using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class loding2 : MonoBehaviour
{
    public Slider slider;
    bool IsDone = false;
    float fTime = 0f;
    AsyncOperation async_operation;

    void Start()
    {
        StartCoroutine(StartLoad("GamePlay2"));
    }

    void Update()
    {
        fTime += Time.deltaTime;
        slider.value = fTime;

        if (fTime >= 5)
        {
            async_operation.allowSceneActivation = true;
        }
    }

    public IEnumerator StartLoad(string strSceneName)
    {
        async_operation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(strSceneName);
        async_operation.allowSceneActivation = false;

        if (IsDone == false)
        {
            IsDone = true;

            while (async_operation.progress < 0.9f)
            {
                slider.value = async_operation.progress;

                yield return true;
            }
        }
    }
}
