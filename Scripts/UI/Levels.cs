using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
    public GameObject selectPanel;
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
        menu.GetComponent<CanvasGroup>().alpha = 0;
        menu.GetComponent<CanvasGroup>().interactable = false;
        menu.GetComponent<CanvasGroup>().blocksRaycasts = false;

        selectPanel.GetComponent<CanvasGroup>().alpha = 1;
        selectPanel.GetComponent<CanvasGroup>().interactable = true;
        selectPanel.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
