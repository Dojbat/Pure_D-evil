using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move_Awake : MonoBehaviour
{
    public bool ZoomActive;

    public Vector3[] Target;

    public Camera cam;

    public float ZoomSpeed;

    void Start()
    {
        cam = Camera.main;
    }

    public void LateUpdate()
    {
        if(ZoomActive == true)
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize,3,ZoomSpeed);
            cam.transform.position = Vector3.Lerp(cam.transform.position,Target[1],ZoomSpeed);
        }
        else
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize,5,ZoomSpeed);
            cam.transform.position = Vector3.Lerp(cam.transform.position,Target[0],ZoomSpeed);
        }
        
    }
}
