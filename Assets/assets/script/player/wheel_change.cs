using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wheel_change : MonoBehaviour
{

    public GameObject skill_wheel;
    public Sprite red_wheel;
    public Sprite blue_wheel;
    public Sprite yellow_wheel;
    public Sprite orange_wheel;
    public Sprite green_wheel;
    public Sprite purple_wheel;
    public Sprite blank_wheel;
    public player_stat stat;

    void Start()
    {
        
    }

  
    void Update()
    {
        if(stat.color == "red")
        {
            skill_wheel.GetComponent<Image>().sprite = red_wheel;            
        }
        else if(stat.color == "blue")
        {
            skill_wheel.GetComponent<Image>().sprite = blue_wheel;            
        }
        else if(stat.color == "yellow")
        {
            skill_wheel.GetComponent<Image>().sprite = yellow_wheel;            
        }
        else if(stat.color == "orange")
        {
            skill_wheel.GetComponent<Image>().sprite = orange_wheel;            
        }
        else if(stat.color == "green")
        {
            skill_wheel.GetComponent<Image>().sprite = green_wheel;            
        }
        else if(stat.color == "purple")
        {
            skill_wheel.GetComponent<Image>().sprite = purple_wheel;            
        }
        else
        {
            skill_wheel.GetComponent<Image>().sprite = blank_wheel;                 
        }
    }

    public void changewheel()
    {
        //skill_wheel.GetComponent<Image>().sprite = red_wheel;        
    }
}
