using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attack : MonoBehaviour
{

    public player_stat stat;
    //public enemy_stat enemyStat;
    public manabar mana;
    public Transform attackPoint;
    public LayerMask enemyLayers;
    public Transform firepoint;
    public GameObject purball;
    public GameObject fireball;
    public GameObject red;
    public GameObject slash;
    public GameObject green;
    public GameObject blue;
    public GameObject hitbox;
    public GameObject yellow;
    public Animator anim;

    public float attackRange = 0.5f;
    public float bulletforce = 10f;


    void Awake()
    {
        stat.ATKCD = stat.originATKCD;
        anim = gameObject.GetComponent<Animator>();
    }
    void Start()
    {
        mana.SetMaxmana(stat.MaxMP);
    }


    void Update()
    {
        mana.Setmana(stat.MP);
        stat.ATKCD -= Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Mouse0) && stat.ATKCD <= 0.0f)
        {

            if(stat.color == "blank")
            {
                Attack();
            }
            else if(stat.color == "red" && stat.MP >= 15)
            {
                redattack();
                //stat.color_clear();
                stat.MP -= 20;
            }
            else if(stat.color == "blue"  && stat.MP >= 10)
            {
                blueattack();
                stat.color_clear();
                stat.MP -= 10;
            }
            else if(stat.color == "yellow" && stat.MP >= 5)
            {
                yellowattack();
                stat.color_clear();
                stat.MP -= 5;
            }
            else if(stat.color == "green" && stat.MP >= 5)
            {
                greenattack();
                stat.color_clear();
                stat.MP -= 5;
            }
            else if(stat.color == "purple" && stat.MP >= 20)
            {
                purpleattack();
                stat.color_clear();
                stat.MP -= 15;
            }
            else if(stat.color == "orange" && stat.MP >= 15 )
            {
                orangeattack();
                stat.color_clear();
                stat.MP -= 15;
            }
            stat.color_clear();
            stat.ATKCD = stat.originATKCD;
        }
    }

    void Attack()
    {
        anim.SetTrigger("attack");
        GameObject bullet = Instantiate(slash,firepoint.position, firepoint.rotation);
        bullet.SetActive(true);
        //Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        //rb.AddForce(firepoint.right * bulletforce, ForceMode2D.Impulse);
        anim.SetBool("Is attack", false);
        stat.color = "blank";
    }

    void redattack()
    {
        anim.SetTrigger("attack");
        GameObject bullet = Instantiate(red,firepoint.position, firepoint.rotation);
        bullet.SetActive(true);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        //rb.AddForce(firepoint.right * bulletforce, ForceMode2D.Impulse);
    }
    
    void purpleattack()
    {
        anim.SetTrigger("attack");
        GameObject bullet = Instantiate(purball,firepoint.position, firepoint.rotation);
        bullet.SetActive(true);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.right * bulletforce, ForceMode2D.Impulse);
    }

    void orangeattack()
    {
        anim.SetTrigger("attack");
        fireball.SetActive(true);

    }

    void greenattack()
    {
        anim.SetTrigger("attack");
        GameObject bullet = Instantiate(green,firepoint.position, firepoint.rotation);
        bullet.SetActive(true);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.right * bulletforce, ForceMode2D.Impulse);
        GameObject Bullet = Instantiate(green,firepoint.position, firepoint.rotation);
        bullet.SetActive(true);
        Rigidbody2D rB = Bullet.GetComponent<Rigidbody2D>();
        rB.AddForce(firepoint.right * (bulletforce + 5), ForceMode2D.Impulse);
    }

    void blueattack()
    {
        anim.SetTrigger("attack");
        GameObject bullet = Instantiate(blue,firepoint.position, firepoint.rotation);
        bullet.SetActive(true);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.right * bulletforce, ForceMode2D.Impulse);
    }
    void yellowattack()
    {
        anim.SetTrigger("attack");
        yellow.SetActive(true);
    }
}

