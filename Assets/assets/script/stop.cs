using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject self;
    public string stoptag; 

    void Start()
    {
        rb = self.GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag == stoptag)
        {
            rb.bodyType = RigidbodyType2D.Static;
        }
    }


    void Update()
    {
        
    }
}
