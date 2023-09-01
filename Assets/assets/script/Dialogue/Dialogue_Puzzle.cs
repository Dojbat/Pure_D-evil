using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue_Puzzle : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public GameObject[] image;
    public int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject backButton;
    private bool start;
    public int[] Select_Sentence_Index;
    public int Index;
    public Choice x;
    public GameObject Frame;
    public int Cindex = 0;



    void Awake()
    {
        Frame.SetActive(true);
        
        if(Mainmanu.start == false)
        {
            Frame.SetActive(true);
           StartCoroutine(Type());
            image[0].SetActive(true); 
            Mainmanu.start = true;  
        }
    }

    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
        if(index == sentences.Length - 1)
        {
            image[index].gameObject.SetActive(false);
            continueButton.SetActive(false);
        }
        if(index == Select_Sentence_Index[Index])
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
            // textDisplay.text = "";
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
            Frame.SetActive(false);
            image[index].gameObject.SetActive(false);
            continueButton.SetActive(false);
        }
    }

}
