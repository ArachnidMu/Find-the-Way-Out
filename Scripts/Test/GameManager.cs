using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject target;
    GameObject player;
    Vector3 alpha;
    GameObject[] boxes;
    GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        boxes = GameObject.FindGameObjectsWithTag("Box");
        target = GameObject.FindGameObjectWithTag("Target");
        player = GameObject.FindGameObjectWithTag("Player");



        MoveBox();
    }

    private void MoveBox()
    {
        for (int i = 0; i < boxes.Length; i++)
        {
            alpha = boxes[i].transform.position - player.transform.position;
            print(alpha);
            if(player.transform.position == boxes[i].transform.position)
            {
                
            }
        }
    }
}
