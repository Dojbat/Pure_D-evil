using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Audio;

public class Change_Audio : MonoBehaviour
{
    public AudioSource normal;
    public AudioSource bosstheme;

    private void OnTriggerEnter2D(Collider2D girl) 
    {
        if(girl.gameObject.tag == "Girl")
        {
            bosstheme.enabled = true;
            normal.enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D girl) 
    {
        if(girl.gameObject.tag == "Girl")
        {
            bosstheme.enabled = false;
            normal.enabled = true;
        }
    }
}
