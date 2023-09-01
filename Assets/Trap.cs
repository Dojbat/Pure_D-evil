using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public player_stat stat;
    public enemy_stat estat;

    private void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.gameObject.tag == "Girl")
        {
            stat.HP -= 1;
            stat.Hearts[stat.HP].SetActive(false);
        }
        if(col.gameObject.name == "slime (3)")
        {
            estat.HP -= 1;
        }

        
    }
}
