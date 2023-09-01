using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gethit : MonoBehaviour
{

    public GameObject splash;
    public Transform self;
    public immune im;

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "hitbox" && im.Isimmune == false)
        {
            GameObject sp = Instantiate(splash ,self.position ,self.rotation);
            sp.SetActive(true);
        }
    }

    void Update()
    {
        
    }
}
