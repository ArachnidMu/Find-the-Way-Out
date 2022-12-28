using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MoveStatus
{
    None,
    Moving,
}

public class EnemyM : MonoBehaviour
{
    GameObject player;
    public float speed = 5;
    MoveStatus moveStatus = MoveStatus.None;
    Vector3 target;
    Vector3 moveDir;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (moveStatus == MoveStatus.None)
        {
            Vector3 dir = player.transform.position - transform.position;

            //判断可以走的方向
            Vector3 horiDir = Vector3.zero;
            Vector3 vertDir = Vector3.zero;
            if (!Mathf.Approximately(dir.x,0))
            {
                horiDir = new Vector3(Mathf.Sign(dir.x),0,0);
            }
            if (!Mathf.Approximately(dir.z, 0))
            {
                vertDir = new Vector3(0, 0, Mathf.Sign(dir.z));
            }

            bool MoveHori = true;
            bool MoveVert = true;
            RaycastHit hitResult;
            if(horiDir == Vector3.zero || Physics.Raycast(transform.position, horiDir, out hitResult, 1))
            {
                MoveHori = false;
            }
            if (vertDir == Vector3.zero || Physics.Raycast(transform.position, vertDir, out hitResult, 1))
            {
                MoveVert = false;
            }

            if(MoveHori && MoveVert)
            {
                if (Mathf.Abs(dir.x) >= Mathf.Abs(dir.z))
                {
                    moveDir = horiDir;
                }
                else
                {
                    moveDir = vertDir;
                }
            }
            else if(MoveHori)
            {
                moveDir = horiDir;
            }
            else if (MoveVert)
            {
                moveDir = vertDir;
            }

            if(MoveHori||MoveVert)
            {
                target = transform.position + moveDir;
                moveStatus = MoveStatus.Moving;
            }
        }
        else if(moveStatus == MoveStatus.Moving)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);

            if (Vector3.Distance(transform.position, player.transform.position) < 0.5)
            {
                Switch.Instance.Reload();
            }

            
            if(moveDir == Vector3.left || moveDir == Vector3.right)
            {
                if (Mathf.Approximately(transform.position.x, target.x))
                {
                    moveStatus = MoveStatus.None;
                }
            }
            else
            {
                if (Mathf.Approximately(transform.position.z, target.z))
                {
                    moveStatus = MoveStatus.None;
                }
            }
        }
    }
}