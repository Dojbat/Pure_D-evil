using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_atack : MonoBehaviour
{
    public immune im;
    public player_stat stat;
    public Animator anim;


    void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.gameObject.tag == "Girl" && im.Isimmune == false)
        {
           anim.SetBool("IsAttack", true);
           stat.HP -= 1;
           stat.Hearts[stat.HP].SetActive(false);
           Debug.Log("hit");
           anim.SetBool("IsAttack", false);
           im.Isimmune = true;
        }
    }
}
