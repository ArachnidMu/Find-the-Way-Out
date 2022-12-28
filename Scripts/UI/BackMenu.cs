using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject keyCount;
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
        Switch.Instance.Back();

        menu.GetComponent<CanvasGroup>().alpha = 1;
        menu.GetComponent<CanvasGroup>().interactable = true;
        menu.GetComponent<CanvasGroup>().blocksRaycasts = true;

        keyCount.GetComponent<CanvasGroup>().alpha = 0;
        keyCount.GetComponent<CanvasGroup>().interactable = false;
        keyCount.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
}
