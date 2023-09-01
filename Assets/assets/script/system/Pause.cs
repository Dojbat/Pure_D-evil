using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenuUI;
    public GameObject Setting;
    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    SavePlayerPos playerPosData;
    public GameObject Gamemanager;

    void Awake()
    {
        playerPosData = FindObjectOfType<SavePlayerPos>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            PauseMenuUI.SetActive(true);
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void Option()
    {
        Setting.SetActive(true);
        T1.SetActive(false);
        T2.SetActive(false);
        T3.SetActive(false);
    }

    public void BackOption()
    {
        T1.SetActive(true);
        T2.SetActive(true);
        T3.SetActive(true);
        Setting.SetActive(false);
    }

    public void MainMenu()
    {
        // playerPosData.PlayerProSave();
        SceneManager.LoadScene("MainMenu");
    }
}