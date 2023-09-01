using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region Public Variables
    public float attackDistance;
    public float rangeDistance;
    public float originmovespeed;
    public float moveSpeed;
    public float intTimer;
    public float timer;
    public Transform leftLimit;
    public Transform rightLimit;
    [HideInInspector] public Transform target;
    [HideInInspector] public bool inRange;
    public GameObject hotZone;
    public GameObject triggerArea;
    public GameObject enemy;
    public GameObject hitbox;
    public enemy_shoot shoot;
    public bool attackMode;
    public bool cooling;
    public bool moving = true;
    public bool Isboss;


    #endregion
    
    #region Private Variables
    private Animator anim;
    private float distance;

    #endregion


    void Awake()
    {
        shoot = hitbox.GetComponent<enemy_shoot>();
        moveSpeed = originmovespeed;
        SelectTarget();
        timer = intTimer;
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        if(!attackMode)
        {
            Move();
        }

        if(!InsideofLimits() && !inRange && !anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            SelectTarget();
        }

        if(inRange)
        {
            EnemyLogic();
        }

        if(timer <= 0)
        {
            cooling = false;
        }

        timer -= Time.deltaTime;
    }

    void EnemyLogic()
    {
        distance = Vector2.Distance(transform.position, target.position);

        if(distance > attackDistance && moving == true)
        {
            StopAttack();
            moveSpeed = originmovespeed;
        }
        else if(attackDistance >= distance && cooling == false)
        {
            Attack();
            Invoke("continuewalk" , 1.0f);
            // cooling = true;
        }
        else if(attackDistance < distance && distance <= rangeDistance && cooling == false && Isboss == true)
        {
            Attack2();
            Invoke("continuewalk" , 1.3f);
        }

        if (cooling == true)
        {
            Cooldown();
            anim.SetBool("IsAttack",false);
            anim.SetBool("IsAttack2",false);
        }
    }

    void Move()
    {
        anim.SetBool("IsWalk", true);
        if(!anim.GetCurrentAnimatorStateInfo(0).IsName("Enemy_attack"))
        {
            Vector2 targetPosition = new Vector2(target.position.x, transform.position.y);

            transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }

    void continuewalk()
    {
        cooling = true;
        moving = true;
    }

    void Attack()
    {
            moving = false;
            moveSpeed = 0;
            attackMode = true;

            anim.SetBool("IsWalk", false);
            anim.SetBool("IsAttack", true);
            timer = intTimer;
    }

    void Attack2()
    {
            moving = false;
            moveSpeed = 0;
            attackMode = true;

            anim.SetBool("IsWalk", false);
            anim.SetBool("IsAttack2", true);
            timer = intTimer;
    }

    void Cooldown()
    {
        if(timer <= 0 && attackMode)
        {
            attackMode = false;
            cooling = false;
            timer = intTimer;
        }
    }

    void StopAttack()
    {
        cooling = false;
        attackMode = false;
        anim.SetBool("IsAttack", false);
        anim.SetBool("IsAttack2", false);
    }


    private bool InsideofLimits()
    {
        return transform.position.x > leftLimit.position.x && transform.position.x < rightLimit.position.x;
    }

    public void SelectTarget()
    {
        float distanceToLeft = Vector2.Distance(transform.position, leftLimit.position);
        float distanceToRight = Vector2.Distance(transform.position, rightLimit.position);

        if(distanceToLeft > distanceToRight)
        {
            target = leftLimit;
        }
        else
        {
            target = rightLimit;
        }

        Flip();
    }

    public void Flip()
    {
        Vector3 rotation = transform.eulerAngles;
        if(transform.position.x > target.position.x)
        {
            rotation.y = 180f;
        }
        else
        {
            rotation.y = 0f;
        }

        transform.eulerAngles = rotation;
    }

    public void slow()
    {
        moveSpeed -= 1;
        intTimer += 0.5f;
    }

    public void respeed()
    {
        moveSpeed += 1;
        intTimer -= 0.5f;
    }
}