using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_object : MonoBehaviour
{

    public GameObject hit;
    public Transform self;

    void Start()
    {

    }


    // void OnTriggerEnter2D (Collider2D col)
    // {
    //     if(col.gameObject.tag == "Enemy")
    //     {
    //         Debug.Log("slash");
    //         GameObject FX = Instantiate(hit,self.position, self.rotation);
    //         FX.SetActive(true);
    //     }
    //}
}
