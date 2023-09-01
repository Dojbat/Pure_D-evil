using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sense : MonoBehaviour
{
    public GameObject Red;
    public GameObject Orange;
    
    private void OnTriggerEnter2D(Collider2D enemy) 
    {
        if(enemy.gameObject.tag == "Enemy")
        {
            Red.SetActive(true);
        }
        if(enemy.gameObject.tag == "ammor")
        {
            Orange.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D enemy) 
    {
        if(enemy.gameObject.tag == "Enemy")
        {
            Red.SetActive(false);
        }
        if(enemy.gameObject.tag == "ammor")
        {
            Orange.SetActive(false);
        }

    }
}
