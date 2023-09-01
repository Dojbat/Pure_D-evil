using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_hint : MonoBehaviour
{
    public GameObject hint;

    private void OnTriggerEnter2D(Collider2D Demon)
    {
        if(Demon.gameObject.tag == "Girl")
        {
            hint.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D Demon)
    {
        if(Demon.gameObject.tag == "Girl")
        {
            hint.SetActive(false);
        }
    }

}
