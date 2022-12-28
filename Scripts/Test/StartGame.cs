using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject keys;
    public GameObject menu;
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnClick()
    {
        Switch.currentLevel = 1;

        GameObject level = Resources.Load<GameObject>("one");
        GameObject levelint = Instantiate(level);

        keys.GetComponent<CanvasGroup>().alpha = 1;
        keys.GetComponent<CanvasGroup>().interactable = true;
        keys.GetComponent<CanvasGroup>().blocksRaycasts = true;

        menu.GetComponent<CanvasGroup>().alpha = 0;
        menu.GetComponent<CanvasGroup>().interactable = false;
        menu.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
}
