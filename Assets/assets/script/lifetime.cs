using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifetime : MonoBehaviour
{

    public float Life = 1.0f;
    public float running = 0.0f;
    public bool des = false;
    public bool ac = false;

    void Start()
    {
        running = Life;
    }


    void Update()
    {
        running -= Time.deltaTime;
        if(running <= 0 && des == true)
        {
            Destroy(gameObject);
        }
        else if(running <= 0 && ac == true)
        {
            running = Life + 0.1f;
            gameObject.SetActive(false);
        }
    }
}
