using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DelayTool : MonoBehaviour
{
    public static DelayTool Instance;
    
    private void Awake()
    {
        Instance = this;
    }

    public void Delay(CustomVoid pDelegate, float time)
    {
        StartCoroutine(TimeWait(pDelegate, time));
    }

    public IEnumerator TimeWait(CustomVoid pDelegate, float time)
    {
        yield return new WaitForSeconds(time);

        pDelegate.Invoke();
    }

    public delegate void CustomVoid();
}
