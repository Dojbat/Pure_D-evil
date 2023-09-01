using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_stat : MonoBehaviour
{

    public int maxHP = 5;
    public int HP;
    public int originATk = 2;
    public int baseATK;
    public int ATK;
    public float originATKCD = 0.25f;
    public float ATKCD;
    public int MaxMP = 100;
    public int MP;
    public string color;
    public string mixed_state = "0";
    public int MoralePoint;
    public int fruit_count;
    public int F;
    public UseFruit UseFruit;
    public GameObject[] Hearts;
    public GameObject[] Fruits;
    public bool yellow = false;



    void Start()
    {
        color = "blank";
        baseATK = originATk;
        ATK = baseATK;
        HP = maxHP;
        MP = MaxMP;
        fruit_count = 0;
        F = 0;
    }

    void Update()
    {
        if(MP > MaxMP)
        {
            MP = MaxMP;
        }
        if(HP == HP - 1)
        {
            Hearts[HP].SetActive(false);
        }
        // if(HP == HP + 1)
        // {
        //     Hearts[HP].SetActive(true);
        //     Hearts[HP-1].SetActive(true);
        //     Hearts[HP-2].SetActive(true);
        //     Hearts[HP-3].SetActive(true);
        //     Hearts[HP-4].SetActive(true);
        // }

         if(HP == HP + 1)
        {
            Hearts[HP].SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.E)) //red clicked
        {
            if(color == "yellow" && mixed_state == "1")
            {
                color = "orange";
                mixed_state = "2";
            }
            
            else if(color == "blue" && mixed_state == "1")
            {
                color = "purple";
                mixed_state = "2";
            }
            else if(mixed_state == "0")
            {
                color = "red";
                mixed_state = "1";
            }
            else if(mixed_state == "2")
            {
                color = "blank";
                mixed_state = "0";
            }

        }
        else if(Input.GetKeyDown(KeyCode.Q)) //yellow clicked
        {
            if(color == "red" && mixed_state == "1")
            {
                color = "orange";
                mixed_state = "2";
            }
            
            else if(color == "blue" && mixed_state == "1")
            {
                color = "green";
                mixed_state = "2";
            }
            else if(mixed_state == "0")
            {
                color = "yellow";
                mixed_state = "1";
            }
            else if(mixed_state == "2")
            {
                color = "blank";
                mixed_state = "0";
            }
        }
        else if(Input.GetKeyDown(KeyCode.F)) //blue clicked
        {
            if(color == "red" && mixed_state == "1")
            {
                color = "purple";
                mixed_state = "2";
            }
            
            else if(color == "yellow" && mixed_state == "1")
            {
                color = "green";
                mixed_state = "2";
            }
            else if(mixed_state == "0")
            {
                color = "blue";
                mixed_state = "1";
            }
            else if(mixed_state == "2")
            {
                color = "blank";
                mixed_state = "0";
            }
        }

        else if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            mixed_state = "0";
        }

        // if(F < fruit_count)
        // {
        //     Fruits[F].SetActive(true);
        //     F += 1;
        // }
        if(UseFruit.Slot1 == true)
        {
            Fruits[0].SetActive(true);
        }
        if(UseFruit.Slot2 == true)
        {
            Fruits[1].SetActive(true);
        }
        
        

        // if(F == fruit_count)
        // {
        //     fruit_count = 0;
        // }
    }

    public void color_clear()
    {
        color = "blank";
    } 
}
