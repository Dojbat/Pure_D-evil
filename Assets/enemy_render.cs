using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_render : MonoBehaviour
{

    public GameObject mon;
    public GameObject lim;

    void Start()
    {

    }


    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Girl"||col.gameObject.tag == "Demon")
        {
            mon.SetActive(true);
            lim.SetActive(true);
        }
    }
    // void OnTriggerExit2D(Collider2D col)
    // {
    //     if(col.gameObject.tag == "Girl"||col.gameObject.tag == "Demon")
    //     {
    //         mon.SetActive(false);
    //         lim.SetActive(false);
    //     }
    // }
}
