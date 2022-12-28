using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeyCount : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Text keynumb;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        keynumb.text = Player3.KeyCount.ToString();
    }
}
