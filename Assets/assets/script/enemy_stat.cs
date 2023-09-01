using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_stat : MonoBehaviour
{

    public player_stat stat;
    public int maxHP = 6;
    public int HP;
    public attack_object obj;
    public int intakeDMG;
    public GameObject selfparent;
    public Enemy enemy;
    public Transform self;
    public GameObject Splash;
    public armorbar bar;
    public bool IsArmor;
    public int armor = 25;
    public GameObject armor_light;

    void Awake()
    {
        HP = maxHP;
        bar = armor_light.GetComponentInChildren<armorbar>();
        bar.SetMaxArmor(armor);
        //bar = armor_light.GetComponentInChildren<armorbar>();
    }


    void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.name == "purple ball(Clone)")
        {
            if(IsArmor == true)
            {
                armor -= 1;
            }
            else if (IsArmor == false)
            {
                HP -= stat.ATK;
                knockback();
            }
            Destroy(collider.gameObject);
            splash();
        }
        else if(collider.name == "red(Clone)")
        {
            if(IsArmor == true)
            {
                armor -= 2;
            }
            else if (IsArmor == false)
            {
                HP -= stat.ATK*2;
                knockback();
            }
            splash();
        }
        else if(collider.name == "fire")
        {
            if(IsArmor == true)
            {
                armor -= 5;
            }
            else if (IsArmor == false)
            {
                HP -= stat.ATK-1;
                knockback();
            }
            splash();
        }
        else if(collider.name == "slash(Clone)")
        {
            if(IsArmor == true)
            {
                armor -= 1;
            }
            else if (IsArmor == false)
            {
                HP -= stat.ATK;
                knockback();
            }
            stat.MP += 5;
            if(stat.yellow == true)
            {
                stat.MP += 5;
            }
            splash();
            stat.yellow = false;
        }
        else if(collider.name == "blue(Clone)")
        {
            enemy.slow();
        }

        else if(collider.name == "yellow")
        {
            if(IsArmor == true)
            {
                armor -= 1;
            }
            else if (IsArmor == false)
            {
                HP -= stat.ATK - 1;
                knockback();
            }
            stat.yellow = true;
            splash();
        }
    }

    void OnTriggerExit2D (Collider2D collider)
    {
        if(collider.name == "blue(Clone)")
        {
            enemy.respeed();
        }
    }
   

    void Die()
    {
        Debug.Log("die");
        Destroy(selfparent);
    }

    void Update()
    {
        bar.SetArmor(armor);

        if(IsArmor == true)
        {
            armor_light.SetActive(true);
        }
        else if(IsArmor == false)
        {
            armor_light.SetActive(false);
        }

        if(armor <= 0)
        {
            IsArmor = false;
        }

        if(HP <= 0)
        {
            Die();
        }


    }

    void splash()
    {
        GameObject sp = Instantiate(Splash,self.position, self.rotation);
        sp.SetActive(true);
    }

    void knockback()
    {
        Rigidbody2D rb = selfparent.GetComponent<Rigidbody2D>();
        Transform tf = selfparent.GetComponent<Transform>();
        rb.AddForce(tf.right * -100f, ForceMode2D.Impulse);
    }
}
