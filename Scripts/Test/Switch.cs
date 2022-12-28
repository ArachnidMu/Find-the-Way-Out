using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Switch : MonoBehaviour
{
    public static Switch Instance;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    GameObject player;
    GameObject target;
    GameObject father;
    public static int currentLevel;
    void Start()
    {
        currentLevel = 1;
        this.GetComponent<Button>().onClick.AddListener(OnClick);
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        target = GameObject.FindGameObjectWithTag("Target");
        father = GameObject.FindGameObjectWithTag("Level");
    }

    private void LateUpdate() 
    {
        if(player != null && target != null && Player3.finished == true)
        {
            CallUI();
        }
    }
    void OnClick()
    {
        for (int i = 0; i < father.transform.childCount; i++)
        {
            father.transform.GetChild(i).gameObject.SetActive(false);

            father.SetActive(false);
        }


        HideUI();

        currentLevel = currentLevel + 1;

        if(currentLevel == 2)
        {
            GameObject level = Resources.Load<GameObject>("two");
            GameObject levelint = Instantiate(level);
        }

        if(currentLevel == 3)
        {
            GameObject level = Resources.Load<GameObject>("three");
            GameObject levelint = Instantiate(level);
        }

        if(currentLevel == 4)
        {
            GameObject level = Resources.Load<GameObject>("four");
            GameObject levelint = Instantiate(level);
        }

        if (currentLevel == 5)
        {
            GameObject level = Resources.Load<GameObject>("five");
            GameObject levelint = Instantiate(level);
        }
        
        if(currentLevel == 6)
        {
            GameObject level = Resources.Load<GameObject>("six");
            GameObject levelint = Instantiate(level);
        }

        if(currentLevel == 7)
        {
            GameObject level = Resources.Load<GameObject>("seven");
            GameObject levelint = Instantiate(level);
        }

        if(currentLevel == 8)
        {
            GameObject level = Resources.Load<GameObject>("eight");
            GameObject levelint = Instantiate(level);
        }

        if(currentLevel == 9)
        {
            GameObject level = Resources.Load<GameObject>("nine");
            GameObject levelint = Instantiate(level);
        }

        if(currentLevel == 10)
        {
            GameObject level = Resources.Load<GameObject>("ten");
            GameObject levelint = Instantiate(level);
        }

        if(currentLevel == 11)
        {
            GameObject level = Resources.Load<GameObject>("eleven");
            GameObject levelint = Instantiate(level);
        }

        if(currentLevel == 12)
        {
            GameObject level = Resources.Load<GameObject>("twelve");
            GameObject levelint = Instantiate(level);
        }
    }

    public void Back()
    {
        father.SetActive(false);
    }

    public void Reload()
    {
        father.SetActive(false);

        Player3.KeyCount = 0;

        if (currentLevel == 1)
        {
            GameObject level = Resources.Load<GameObject>("one");
            GameObject levelint = Instantiate(level);
        }

        if (currentLevel == 2)
        {
            GameObject level = Resources.Load<GameObject>("two");
            GameObject levelint = Instantiate(level);
        }

        if (currentLevel == 3)
        {
            GameObject level = Resources.Load<GameObject>("three");
            GameObject levelint = Instantiate(level);
        }

        if (currentLevel == 4)
        {
            GameObject level = Resources.Load<GameObject>("four");
            GameObject levelint = Instantiate(level);
        }

        if (currentLevel == 5)
        {
            GameObject level = Resources.Load<GameObject>("five");
            GameObject levelint = Instantiate(level);
        }

        if(currentLevel == 6)
        {
            GameObject level = Resources.Load<GameObject>("six");
            GameObject levelint = Instantiate(level);
        }

        if(currentLevel == 7)
        {
            GameObject level = Resources.Load<GameObject>("seven");
            GameObject levelint = Instantiate(level);
        }

        if(currentLevel == 8)
        {
            GameObject level = Resources.Load<GameObject>("eight");
            GameObject levelint = Instantiate(level);
        }

        if(currentLevel == 9)
        {
            GameObject level = Resources.Load<GameObject>("nine");
            GameObject levelint = Instantiate(level);
        }

        if(currentLevel == 10)
        {
            GameObject level = Resources.Load<GameObject>("ten");
            GameObject levelint = Instantiate(level);
        }

        if(currentLevel == 11)
        {
            GameObject level = Resources.Load<GameObject>("eleven");
            GameObject levelint = Instantiate(level);
        }

        if(currentLevel == 12)
        {
            GameObject level = Resources.Load<GameObject>("twelve");
            GameObject levelint = Instantiate(level);
        }
    }

    private void CallUI()
    {
        if(Vector3.Distance(player.transform.position,target.transform.position) < 0.5)
        {
            GetComponent<CanvasGroup>().alpha = 1;
            GetComponent<CanvasGroup>().interactable = true;
            GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
    }

    private void HideUI()
    {
        GetComponent<CanvasGroup>().alpha = 0;
        GetComponent<CanvasGroup>().interactable = false;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
}
