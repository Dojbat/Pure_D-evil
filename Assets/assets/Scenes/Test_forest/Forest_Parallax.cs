using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest_Parallax : MonoBehaviour
{
    float length, startpos;
    public GameObject cam;
    public float parallaxEffect;

    void Start()
    {
        startpos = transform.position.x; //get start pos
        length = GetComponent<SpriteRenderer>().bounds.size.x; //Get length
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //float temp = (cam.transform.position.x* (1 - parallaxEffect));
        float dist = (cam.transform.position.x* parallaxEffect);

        transform.position = new Vector3(startpos + dist, transform.position.y,transform.position.z); //ย้ายภาพ

        //if (temp > startpos * length) startpos += length;
        //else if (temp < startpos - length) startpos -= length;
    }
}
