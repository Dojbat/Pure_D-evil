using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Text_Control : MonoBehaviour
{
    public GameObject[] Count;
    int index;
    
    void Start()
    {
        index = 0;
    }

    void Awake()
    {
        Count[0].gameObject.SetActive(true);
    }

    public void Check()
    {
        if(Slot.checkitem1 == false)
        {
            index += 1;
            for(int i = 0 ; i < Count.Length ; i++)
            {
                Count[i].gameObject.SetActive(false);
                Count[index].gameObject.SetActive(true);
            } 
            
            if(index == Count.Length - 1)
            {
                index = 0;
            }
        }
        
    }


}
