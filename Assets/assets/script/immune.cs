using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class immune : MonoBehaviour
{

    public SpriteRenderer girl;
    public Animator flick;
    public float immunetime = 2.0f ;
    public float runningtime;
    public bool Isimmune = false;


    void Start()
    {

    }

    void Update()
    {
        if(Isimmune == true)
        {
            flick.enabled = true;
            runningtime += Time.deltaTime;
        }

        else if(Isimmune == false)
        {
            flick.enabled = false;
            girl.enabled = true;
        }

        if(runningtime >= immunetime)
        {
            Isimmune = false;
            runningtime = 0;
        }
    }
}
