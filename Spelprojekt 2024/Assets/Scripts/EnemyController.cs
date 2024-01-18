using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator anim;
    public Transform target;
    public Transform homePos;
    public float speed;
    public float maxRange;
    public float minRange;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Vector3.Distance(target.position, transform.position)<= maxRange && Vector3.Distance(target.position, transform.position)>= minRange)
        {
            Debug.Log("Follow");
            FollowPlayer();
        }
        else if (Vector3.Distance(target.position, transform.position)>= maxRange)
        {
            Debug.Log("Gohome");
            GoHome();
        }
    }
    public void FollowPlayer()
    {
        anim.SetBool("WithinRange", true);
        anim.SetFloat("MoveHorizontal", (target.position.x - transform.position.x));
        anim.SetFloat("MoveVertical", (target.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    public void GoHome()
    {
        anim.SetFloat("MoveHorizontal", (homePos.position.x - transform.position.x));
        anim.SetFloat("MoveVertical", (homePos.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, homePos.position, speed * Time.deltaTime); 

        if(Vector3.Distance(transform.position, homePos.position) == 0)
        {
            anim.SetBool("WithinRange", false);
        }
    }
}
