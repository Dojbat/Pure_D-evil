using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        // SceneManager.LoadScene("Forest_Background_Test");
        SceneManager.LoadScene("Present");
    }

}
    
