using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Puzzle : MonoBehaviour
{
    private Renderer renderer;
    public GameObject Door;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        if(collider.gameObject.tag == "PDB")
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
