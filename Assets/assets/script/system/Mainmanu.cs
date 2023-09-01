using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmanu : MonoBehaviour
{
    public static bool start = false;
    SavePlayerPos playerPosData;
    
    public void NewGame ()
    {
        // PlayerPrefs.DeleteKey("X");
        // PlayerPrefs.DeleteKey("Y");
        // PlayerPrefs.DeleteKey("XD");
        // PlayerPrefs.DeleteKey("YD");
        SceneManager.LoadScene("Start");
        // SceneManager.LoadScene("Present");
    }
    
    public void LoadGame()
    {   
        
        // SceneManager.LoadScene("Forest_Background_Test");
        SceneManager.LoadScene("Present");
        Time.timeScale = 1;
        
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
        Time.timeScale = 0;
    }
}
