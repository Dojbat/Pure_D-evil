using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Parallax : MonoBehaviour
{
//     Transform cam; //get main cam
//     Vector3 camStartPos;
//     float distance; // distance between the camera start position and current possition

//     GameObject[] bg; // list ของ bg
//     Material[] mat; // material
//     float[] backSpeed;

//     float farthestBack;

//     [Range(0.01f,0.05f)]
//     public float parallaxSpeed;

//     void Start()
//     {
//         cam = Camera.main.transform;
//         camStartPos = cam.position;

//         int BackCount = transform.childCount;
//         mat = new Material[backCount];
//         backSpeed = new float[backCount];

//         for (int i = 0; i < backCount; i++)
//         {
//             bg[i] = transform.GetChild(i).gameObject;
//             mat[i] = bg[i].GetComponent<Renderer>().material;
//         }
//     }

//     void SpeedCalculate(int backCount) //Set Speed of background acording to the distance from the camera
//     {
//         for (int i = 0; i < backCount; i++) //Find the farthest background
//         {
//             if ((bg[i].transform.position.z - cam.position.z) > farthestBack)
//             {
//                 farthestBack = bg[i].transform.position.z - cam.position.z;
//             }
//         }


//     }
}
