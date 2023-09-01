using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour
{
    public demon_movement move;
    public float dashspeed;
    public float origindashtime = 0.25f;
    public float dashtime;
    public float origindashCD;
    public float dashCD;
    public bool dashing = false;

    void Start()
    {
        dashspeed = move.MovementSpeed * 5;
    }
    
    void Update()
    {

        dashtime -= Time.deltaTime;

        if(dashing == true)
        {
            //dashtime = origindashtime;
            dashtime -= Time.deltaTime;
        }

        if(dashtime <= 0)
        {
            dashing = false;
            move.MovementSpeed = move.originspeed;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && dashCD <= 0)
        {
            dashtime = origindashtime;
            move.MovementSpeed = dashspeed;
            dashing = true;
        }
    }
}
