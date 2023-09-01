using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchhit : MonoBehaviour
{
    public GameObject switcH;
    public Sprite Onstate;
    public Sprite Offstate;
    public bool IsOn;
    public string active = "blank";
    public Door door;
    public bool End;


    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag == active && IsOn == false)
        {
            IsOn = true;
            End = true;
        }
        else if(col.gameObject.tag == active && IsOn == true)
        {
            IsOn = false;
        }
        
        if(switcH.name == "orange switch_P")
        {
            if(IsOn == true)
            {
                door.one = true; 
            }
            
        }
        if(switcH.name == "Green Switch_P")
        {
            if(IsOn == true)
            {
                door.two = true;
            }
            
        }
        if(switcH.name == "purple switch_P")
        {
            if(IsOn == true)
            {
                door.three = true;
            }
            
        }
    }

    void Update()
    {
        if(IsOn == true)
        {
            switcH.GetComponent<SpriteRenderer>().sprite = Onstate;
        }
        if(IsOn == false)
        {
            switcH.GetComponent<SpriteRenderer>().sprite = Offstate;
        }

        
    }

}
