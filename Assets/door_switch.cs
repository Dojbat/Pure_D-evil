using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_switch : MonoBehaviour
{

    public GameObject switches;
    public int count;
    public switchhit hit;

    void Start()
    {
        hit = switches.GetComponent<switchhit>();
    }

    void Update()
    {
        if(hit.IsOn == true)
        {
            gameObject.SetActive(false);
        }
    }
}
