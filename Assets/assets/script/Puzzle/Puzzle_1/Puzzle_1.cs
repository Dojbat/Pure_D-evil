using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle_1 : MonoBehaviour
{
    public GameObject puzzle_screen;
    public GameObject dialogue;
    public Respawn res;
    // public GameObject Press_E;


    void OnTriggerEnter2D(Collider2D Demon) 
    {
        // Press_E.SetActive(true);

        // if(Demon.gameObject.tag == "Demon")
        // {
        //     // Press_E.SetActive(false);
        //     puzzle_screen.SetActive(true);
        // }
        res.girl_spawn.position = res.girl_spawn2.position;
        res.demon_spawn.position = res.demon_spawn2.position;
    }
    // private void OnTriggerExit2D(Collider2D other) 
    // {
    //     Press_E.SetActive(false);
    // }
    
}
