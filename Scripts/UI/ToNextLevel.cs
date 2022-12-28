using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ToNextLevel : MonoBehaviour
{
    private Scene currentScene;
    private int newScene;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);

        newScene = 1;
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void OnClick()
    {
        SceneManager.UnloadSceneAsync(newScene);
        SceneManager.LoadSceneAsync(newScene + 1, LoadSceneMode.Additive);

        newScene = newScene + 1;
        
        GameObject.FindGameObjectWithTag("SwitchUI").SetActive(false);
    }
}
