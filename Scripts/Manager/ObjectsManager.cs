using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsManager : MonoBehaviour
{
    private MeshRenderer thisRenderer;
    float shakeTime = 0f;
    public static bool isShake = false;
    // Start is called before the first frame update
    void Start()
    {
        thisRenderer = this.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Shake();
    }

    public void Shake()
    {
        if(isShake)
        {
            shakeTime += Time.deltaTime;

            if(shakeTime % 1 > 0.5f)
            {
                thisRenderer.enabled = true;
            }
            else
            {
                thisRenderer.enabled = false;
            }
        }
        else
        {
            thisRenderer.enabled = true;
        }
    }
}
