using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseFruit : MonoBehaviour
{
    public player_stat stat;
    public bool Slot1;
    public bool Slot2;

    void Update()
    {
        if(stat.HP < stat.maxHP)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1) && Slot1 == true)
            {
                stat.fruit_count -= 1;
                stat.F -= 1;
                stat.HP += 1;
                stat.Hearts[stat.HP - 1].SetActive(true);
                stat.Fruits[0].SetActive(false);
                Debug.Log("Eat1");
                Slot1 = false;
                stat.MP += 25;
            }
        
            if(Input.GetKeyDown(KeyCode.Alpha2) && Slot2 == true)
            {
                stat.fruit_count -= 1;
                stat.F -= 1;
                stat.HP += 1;
                stat.Hearts[stat.HP - 1].SetActive(true);
                stat.Fruits[1].SetActive(false);
                Debug.Log("Eat2");
                Slot2 = false;
                stat.MP += 25;
            }
        }
        else if(stat.MP < 100 && stat.fruit_count > 0)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1) && Slot1 == true)
            {
                stat.fruit_count -= 1;
                stat.F -= 1;
                // stat.HP += 1;
                // stat.Hearts[stat.HP - 1].SetActive(true);
                stat.Fruits[0].SetActive(false);
                Debug.Log("Eat1");
                Slot1 = false;
                stat.MP += 25;
            }
        
            if(Input.GetKeyDown(KeyCode.Alpha2) && Slot2 == true)
            {
                stat.fruit_count -= 1;
                stat.F -= 1;
                stat.HP += 1;
                // stat.Hearts[stat.HP - 1].SetActive(true);
                // stat.Fruits[1].SetActive(false);
                Debug.Log("Eat2");
                Slot2 = false;
                stat.MP += 25;
            }
        }
        
    }

    
}
