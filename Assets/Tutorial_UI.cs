using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_UI : MonoBehaviour
{
    public GameObject TUI;

    private void OnTriggerEnter2D(Collider2D gameobject) 
    {
        if(gameobject.tag == "Girl")
        {
            TUI.SetActive(true);
        }
    }
}
