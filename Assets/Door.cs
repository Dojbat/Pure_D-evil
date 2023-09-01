using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
   public bool one = false;
   public bool two = false;
   public bool three = false;
   public switchhit switchhit1;
   public switchhit switchhit2;
   public switchhit switchhit3;
   public GameObject hint;
   public Dialogue_Switch P_T;
   public int count;

    void Update()
    {
        if(one == true && two == true && three == true)
        {
            gameObject.SetActive(false);
        }
        if(one == false)
        {
            two = false;
            three = false;
            
        }
        if(two == false)
        {
            // one = false;
            three = false;
            // switchhit1.IsOn = false;
            // switchhit3.IsOn = false;
        }
        if(switchhit1.IsOn == false && switchhit2.IsOn == true && switchhit3.IsOn == true)
        {
            switchhit1.IsOn = false;
            switchhit2.IsOn = false;
            switchhit3.IsOn = false;
            count += 1;
        }
        if(switchhit1.IsOn == true && switchhit2.IsOn == false && switchhit3.IsOn == true)
        {
            switchhit1.IsOn = false;
            switchhit2.IsOn = false;
            switchhit3.IsOn = false;
            count += 1;
        }
        
        if(switchhit2.IsOn == true && two == false && switchhit1.IsOn == true)
        {
            switchhit1.IsOn = false;
            switchhit2.IsOn = false;
            switchhit3.IsOn = false;
            count += 1;
        }

        if(switchhit1.IsOn == false)
        {
            one = false;
        }

        if(count == 3)
        {
            hint.SetActive(true);
            count += 1;
        }
        if(count == 6)
        {
            hint.SetActive(true);
            P_T.textDisplay.text = "";
            P_T.StartCoroutine(P_T.Type());
            count += 1;
        }
    }


}
