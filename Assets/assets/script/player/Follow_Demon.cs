using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Demon : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public Animator anim;

    private Transform target;

    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Demon").GetComponent<Transform>();
    }

    // void Update()
    // {
    //     if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
    //     {
    //         transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    //         anim.SetFloat("Speed", Mathf.Abs(speed));
    //     }
    //     else
    //     {
    //         anim.SetFloat("Speed", Mathf.Abs(0));
    //     }
        
    //     if(transform.position.x >= target.position.x)
    //     {
    //         transform.eulerAngles = new Vector3 (0, 0, 0);
    //     }
    //     else if(transform.position.x <= target.position.x)
    //     {
    //         transform.eulerAngles = new Vector3 (0, 180, 0);
    //     }
    // }
}
