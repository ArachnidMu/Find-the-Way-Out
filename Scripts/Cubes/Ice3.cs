using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice3 : MonoBehaviour
{
    Vector3 Target;
    Vector3 MoveDir;
    float Speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 NextPostion = transform.position + Time.deltaTime * Speed * MoveDir;
        if(Vector3.Distance(NextPostion, transform.position) > Vector3.Distance(Target, transform.position))
        {
            transform.position = Target;
        }
        else
        {
            transform.Translate(Time.deltaTime * Speed * MoveDir);
        }
    }

    public bool Move(Vector3 MoveDir)
    {
        return CheckNextBlock(MoveDir);
    }

    private bool CheckNextBlock(Vector3 MoveDir)
    {
        RaycastHit HitResult;
        bool isHit = Physics.Raycast(transform.position, MoveDir, out HitResult, Mathf.Infinity);
        if(isHit)
        {
            Target = HitResult.transform.position - MoveDir;
            this.MoveDir = MoveDir;
        }

        return false;
    }
}
