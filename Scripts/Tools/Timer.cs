using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float totalTime = 3;
    float timer = 0;
    public static bool isStartTimer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isStartTimer)
        {
            timer += Time.deltaTime;
            if(timer > totalTime)
            {
                isStartTimer = false;
                timer = 0;
            }
        }
    }
}
