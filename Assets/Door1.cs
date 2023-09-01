using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    private Renderer renderer;
    public GameObject Door;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        if(collider.gameObject.tag == "BDB")
        {
            renderer.material.color = Color.green;
            Door.SetActive(false);
        }
        else
        {
            renderer.material.color = Color.red;
        }
    }
    void OnTriggerExit2D(Collider2D other) 
    {
        renderer.material.color = Color.white;
    }
}
