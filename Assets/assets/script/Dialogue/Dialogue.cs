using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;

public class Dialogue : MonoBehaviour
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
    public GameObject girl;
    public GameObject Demon;
    public GameObject change_cam;
    public AudioSource[] voice;


    void Awake()
    {
        Demon.GetComponent<demon_movement>().enabled = false;
        girl.GetComponent<movement>().enabled = false;
        girl.GetComponent<attack>().enabled = false;
        change_cam.GetComponent<Change_Camera>().enabled = false;
        Frame.SetActive(true);
        index = 0;
        Frame.SetActive(true);
        StartCoroutine(Type());
        voice[0].enabled = true;
        image[0].SetActive(true); 
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
            voice[i].enabled = false;
            voice[index].enabled = true;
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
            Demon.GetComponent<demon_movement>().enabled = true;
            // girl.GetComponent<movement>().enabled = true;
            change_cam.GetComponent<Change_Camera>().enabled = true;
            girl.GetComponent<attack>().enabled = false;
        }
    }

}
