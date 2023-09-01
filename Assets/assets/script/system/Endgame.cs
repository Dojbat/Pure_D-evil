using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{
    public GameObject UI;
    public GameObject Boar;
    public GameObject Grid;
    public GameObject Door;
    public GameObject Girl;
    public GameObject Demon;

    void Update()
    {
        if(Boar == false)
        {
            Door.SetActive(true);
            Grid.SetActive(false);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D col) 
    {
        if(Boar == false)
        {
            if(col.gameObject.tag == "Girl")
            {
                UI.SetActive(true);
                Girl.SetActive(false);
                Demon.SetActive(false);

            }
        }
    }
}
