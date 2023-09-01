using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour
{
    public GameObject Demon;
    public Vector3 position;
    public demon_movement move;
    void Awake()
    {
        Demon.transform.position = position;
        move.enabled = true;
    }
}
