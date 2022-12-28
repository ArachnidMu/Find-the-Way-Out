using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{
    public string startSceneName = string.Empty;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadSceneSetActive(startSceneName));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {

    }

    private IEnumerator LoadSceneSetActive(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        Scene newScene = SceneManager.GetSceneAt(SceneManager.sceneCount - 1);

        SceneManager.SetActiveScene(newScene);
    }

    private void IsReach()
    {   

    }
}
