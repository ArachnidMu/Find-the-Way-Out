using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownSeal : MonoBehaviour
{
    GameObject[] colorCubes;
    public int brownNumber;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UnSeal();
    }

    public void UnSeal()
    {
        colorCubes = GameObject.FindGameObjectsWithTag("Brown");
        brownNumber = colorCubes.Length;

        if(brownNumber == 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
