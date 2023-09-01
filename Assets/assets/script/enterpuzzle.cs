using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enterpuzzle : MonoBehaviour
{

    public GameObject puzzle;
    public GameObject puzzleUI;

    void Start()
    {
        
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.name == "Demon")
        {
            puzzle.SetActive(true);
            puzzleUI.SetActive(true);
        }
    }

    void Update()
    {
        
    }
}
