using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerPos : MonoBehaviour
{
    public GameObject girl;
    public GameObject Demon;
    private Vector3 startPos;


    public void PlayerProSave()
    {
        var xPos = girl.transform.position.x;
        var yPos = girl.transform.position.y;
        var xPosD = Demon.transform.position.x;
        var yPosD = Demon.transform.position.y;
        PlayerPrefs.SetFloat("X",xPos);
        PlayerPrefs.SetFloat("Y",yPos);
        PlayerPrefs.SetFloat("XD",xPosD);
        PlayerPrefs.SetFloat("YD",yPosD);
        PlayerPrefs.Save();
        Debug.Log("Player Position Load");
        
    }

    public void PlayerPosLoad()
    {
        girl.transform.position = new Vector2(PlayerPrefs.GetFloat("X"),PlayerPrefs.GetFloat("Y"));
        Demon.transform.position = new Vector2(PlayerPrefs.GetFloat("XD"),PlayerPrefs.GetFloat("YD"));
        // PlayerPrefs.SetInt("TimeToLoad", 1);
       
    }
}
