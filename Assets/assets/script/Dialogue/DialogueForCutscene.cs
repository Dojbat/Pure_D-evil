using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueForCutscene : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public GameObject[] image;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    private bool start;


    void Start()
    {
        StartCoroutine(Type());
    }

    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
        if(index == sentences.Length - 1)
        {
            continueButton.SetActive(false);
        }
        
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        
    }

    public void NextSentences()
    {
        continueButton.SetActive(false);
        
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        } 
        else
        {
            textDisplay.text = "";
        }

        for(int i = 0 ; i < sentences.Length ; i++)
        {
            image[i].gameObject.SetActive(false);
            image[index].gameObject.SetActive(true);
        }
    }

    // public void Back()
    // {
    //     index -= 1;
    //     backButton.SetActive(false);
    //     if(index < sentences.Length)
    //     {
    //         textDisplay.text = "";
    //         StartCoroutine(Type());
    //     }

    //     if(index == 0)
    //     {
    //         backButton.SetActive(false);
    //     }
    // }
    public void end()
    {
        if(index == sentences.Length - 1)
        {
            Time.timeScale = 1;
            // image[index].gameObject.SetActive(false);
        }
    }

}