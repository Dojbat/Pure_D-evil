using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP_bar : MonoBehaviour
{
    public Slider slider;
    public Image fill;

    public void SetMaxhp(int hp)
    {
        slider.maxValue = hp;
        slider.value = hp;

    }
    
    public void Sethp(int hp)
    {
        slider.value = hp;
    }
}