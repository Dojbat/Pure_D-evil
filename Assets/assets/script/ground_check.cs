using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_check : MonoBehaviour
{
    
    public bool ground;
    public bool floor = false;
    public bool green = false;

    void Start()
    {
        ground = true;
    }

    void Update()
    {
        if(floor == true||green == true)
        {
            ground = true;
        }
        else
        {
            ground = false;
        }
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag == "ground")
        {
            floor = true;
        }
        if(col.gameObject.tag == "green")
        {
            green = true;
        }
        // else
        // {
        //     floor = false;
        // }
    }

    void OnTriggerExit2D (Collider2D col)
    {
        if(col.gameObject.tag == "ground")
        {
            floor = false;
        }
        if(col.gameObject.tag == "green")
        {
            green = false;
        }
        // else
        // {
        //     floor = false;
        // }
    }

    void OnTriggerStay2D (Collider2D col)
    {
        
        // if(col.gameObject.tag == "green")
        // {
        //     green = true;
        // }
    }
    // void OnTriggerExit2D (Collider2D col)
    // {
    //     if(col.gameObject.tag == "ground")
    //     {
    //         ground = false;
    //         Debug.Log("out");
    //     }
    // }
}
