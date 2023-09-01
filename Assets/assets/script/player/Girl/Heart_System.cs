using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart_System : MonoBehaviour
{
    public GameObject girls;
    public GameObject demon;
    // public GameObject CheckPointUI;
    public player_stat stat;
    public GameObject[] hearts;
    private int life;
    private bool dead;


    // private static Vector3 spawnPoint;
    
    

    private void Start()
    {
        dead = false;
        // spawnPoint = transform.position;
    }

    void Update()
    {
        if(dead == true)
        {
            girls.SetActive(false);
        }
    }

    public void TakeDamage()
    {
        if (stat.HP >= 1)
        {
            stat.HP -= 1;
            hearts[stat.HP].gameObject.SetActive(false);
            if (stat.HP <= 0)
            {
                dead = true;
                Debug.Log("You Dead!");
            }
        }
    }
}
