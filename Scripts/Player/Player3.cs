using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour
{
    GameObject target;
    public static Vector3 boxalpha;
    public static bool finished;
    public static int KeyCount = 0;
    float KeyInterval = 0.15f;
    float TimeCount;
    // Start is called before the first frame update
    void Start()
    {
        finished = false;
        target = GameObject.FindGameObjectWithTag("Target");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Switch.Instance.Reload();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            CheckNextBlock(Vector3.forward);
            TimeCount = 0;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            CheckNextBlock(Vector3.back);
            TimeCount = 0;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            CheckNextBlock(Vector3.left);
            TimeCount = 0;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            CheckNextBlock(Vector3.right);
            TimeCount = 0;
        }

        TimeCount += Time.deltaTime;
        if(TimeCount > KeyInterval)
        {
            if (Input.GetKey(KeyCode.W))
            {
                CheckNextBlock(Vector3.forward);
            }
            if (Input.GetKey(KeyCode.S))
            {
                CheckNextBlock(Vector3.back);
            }
            if (Input.GetKey(KeyCode.A))
            {
                CheckNextBlock(Vector3.left);
            }
            if (Input.GetKey(KeyCode.D))
            {
                CheckNextBlock(Vector3.right);
            }
            TimeCount = 0;
        }
    }

    private void CheckNextBlock(Vector3 MoveDir)
    {
        RaycastHit HitResult;
        bool isHit = Physics.Raycast(transform.position, MoveDir, out HitResult, 1);
        if (isHit)
        {

            if (HitResult.transform.CompareTag("Block"))
            {
                return;
            }
            else if (HitResult.transform.CompareTag("Box"))
            {
                Boxes box = HitResult.transform.GetComponent<Boxes>();
                if (box.Move(MoveDir))
                {
                    return;
                }
            }
            else if (HitResult.transform.CompareTag("Ice"))
            {
                Ice box = HitResult.transform.GetComponent<Ice>();
                if (box.Move(MoveDir))
                {
                    return;
                }
            }
            else if (HitResult.transform.CompareTag("Target"))
            {
                transform.Translate(MoveDir);
                GetComponent<Renderer>().enabled = false;
                finished = true;
                print("Game Over");
            }
            else if (HitResult.transform.CompareTag("Key"))
            {
                KeyCount++;
                Destroy(HitResult.transform.gameObject);
                return;
            }
            else if(HitResult.transform.CompareTag("Door"))
            {
                if(KeyCount>0)
                {
                    KeyCount--;
                    Destroy(HitResult.transform.gameObject);
                }
                return;
            }
            else if (HitResult.transform.CompareTag("Blue"))
            {
                Destroy(HitResult.transform.gameObject);
                return;
            }
            else if (HitResult.transform.CompareTag("Brown"))
            {
                Destroy(HitResult.transform.gameObject);
                return;
            }

        }
        else
        {
            transform.Translate(MoveDir);
        }
       
    }

}