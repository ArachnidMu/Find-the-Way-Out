using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level8 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject keys;
    public GameObject pannel;
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
        Switch.currentLevel = 8;
        
        GameObject level = Resources.Load<GameObject>("eight");
        GameObject levelint = Instantiate(level);

        keys.GetComponent<CanvasGroup>().alpha = 1;
        keys.GetComponent<CanvasGroup>().interactable = true;
        keys.GetComponent<CanvasGroup>().blocksRaycasts = true;

        pannel.GetComponent<CanvasGroup>().alpha = 0;
        pannel.GetComponent<CanvasGroup>().interactable = false;
        pannel.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
}