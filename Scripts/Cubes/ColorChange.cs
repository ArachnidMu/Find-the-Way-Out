using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor();
    }

    public void ChangeColor()
    {
        if(transform.position.x == player.transform.position.x && transform.position.z == player.transform.position.z)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            this.tag = "Red";
        }
    }
}
