using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUP_item : MonoBehaviour
{
    public player_stat stat;
    public UseFruit UseFruit;

    private void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.gameObject.tag == "Girl" && stat.fruit_count < 2)
        {
            stat.fruit_count += 1;
            gameObject.SetActive(false);
            
            if(UseFruit.Slot1 == false)
            {
                UseFruit.Slot1 = true;
            }
            else if(UseFruit.Slot1 == true)
            {
                UseFruit.Slot2 = true;
            }
        }

        

    }

}
