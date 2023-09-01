using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public Transform Girl;
    public Transform Demon;
    public Transform girl_spawn;
    public Transform demon_spawn;
    public Transform girl_spawn2;
    public Transform demon_spawn2;
    public player_stat stat;
    public GameObject Girls;
    public GameObject RespawnUI;
    public GameObject checkpoint;
    public attack g_atk;
    public girldash g_dash;
    public movement g_move;

    
    // void Awake()
    // {
    //    Girl
    // }

    void Update()
    {
        if(stat.HP <= 0)
        {
            Time.timeScale = 0;
            RespawnUI.gameObject.SetActive(true);
        }
    }
    
    public void Spawn()
    {
        Time.timeScale = 1;
        RespawnUI.SetActive(false);
        Girls.SetActive(true);
        Girl.position = girl_spawn.position;
        Demon.position = demon_spawn.position;
        stat.HP = 3;
        stat.Hearts[stat.HP - 3].SetActive(true);
        stat.Hearts[stat.HP - 2].SetActive(true);
        stat.Hearts[stat.HP - 1].SetActive(true);
        stat.MP = stat.MaxMP;
    }

}
