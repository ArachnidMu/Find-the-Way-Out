using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    GameObject[] blocks;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        blocks = GameObject.FindGameObjectsWithTag("Block");

        //Movement();

    }
    private void Movement()
    {
        for (int i = 0; i < blocks.Length; i++)
            if (transform.position != blocks[i].transform.position)
            {

            }
            else
            {
                transform.position -= Player3.boxalpha;
            }
    }

    public bool Move(Vector3 MoveDir)
    {
        return CheckNextBlock(MoveDir);
    }

    private bool CheckNextBlock(Vector3 MoveDir)
    {
        RaycastHit HitResult;
        bool isHit = Physics.Raycast(transform.position, MoveDir, out HitResult, 1);
        if (isHit)
        {
            if (HitResult.transform.CompareTag("Block")|| HitResult.transform.CompareTag("Blue")||HitResult.transform.CompareTag("Brown"))
            {
                return false;
            }
            else if (HitResult.transform.CompareTag("Box"))
            {
                return false;
            }
            else if (HitResult.transform.CompareTag("Enemy"))
            {
                return false;
            }
            else if (HitResult.transform.CompareTag("Ice"))
            {
                return false;
            }

        }
        transform.Translate(MoveDir);
        return true;
    }

}
