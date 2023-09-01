using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Demon : MonoBehaviour
{
    public GameObject demon;
    public GameObject CheckPointUI;
    public GameObject[] hearts;
    private int life;
    private bool dead;

    public GameObject respawnUI;

    private Vector3 spawnPoint;
    
    

    private void Start()
    {
        life = hearts.Length;
        dead = false;
        spawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(dead == true)
        {
            demon.SetActive(false);
            respawnUI.SetActive(true);
        }
    }

    public void TakeDamage(int d)
    {
        if (life >= 1)
        {
            dead = false;
            life -= d;
            hearts[life].gameObject.SetActive(false);
            if (life < 1)
            {
                dead = true;
                Debug.Log("You Dead!");
            }
        }
    }
    
    public void respawn()
    {
        dead = false;
        transform.position = spawnPoint;
        demon.SetActive(true);
        respawnUI.SetActive(false);
        hearts[0].gameObject.SetActive(true);
        hearts[1].gameObject.SetActive(true);
        hearts[2].gameObject.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(CheckPointUI == true)
        {
            if(collision.tag == "CheckPoint")
            {
                Debug.Log("CheckPoint");
                spawnPoint = transform.position;
            } 
        }
        
    }
}
