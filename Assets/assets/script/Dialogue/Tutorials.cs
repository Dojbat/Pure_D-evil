using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorials : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public int index;
    public float typingSpeed;
    // public GameObject continueButton;
    private bool start;
    public GameObject girl;
    public GameObject Demon;
    public GameObject change_cam;
    public GameObject Tutorial;
    public int[] limitindex;



    void Awake()
    {
        // Demon.GetComponent<demon_movement>().enabled = false;
        // girl.GetComponent<movement>().enabled = false;
        // girl.GetComponent<attack>().enabled = false;
        // change_cam.GetComponent<Change_Camera>().enabled = false;
        StartCoroutine(Type());
    }

    void Update()
    {
        // textDisplay.text = sentences[index];

        if (textDisplay.text == sentences[index])
        {
            // continueButton.SetActive(true);
        }

        if(index >= sentences.Length)
        {
            Tutorial.SetActive(false);
            // continueButton.SetActive(false);
            girl.GetComponent<movement>().enabled = false;
            change_cam.GetComponent<Change_Camera>().enabled = true;
            girl.GetComponent<attack>().enabled = false;
            Demon.GetComponent<demon_movement>().enabled = true;
        }

        if(textDisplay.text == sentences[0])
        {
            if(Input.GetKeyDown(KeyCode. A) || Input.GetKeyDown(KeyCode. D))
            {
                index ++;
                textDisplay.text = "";
                StartCoroutine(Type());
            }
            
        }

        // if(index == limitindex[0])
        // {
        //     textDisplay.text = sentences[index];
        // }

        // if(index == sentences.Length - 1)
        // {
        //     continueButton.SetActive(false);
        // }
    }

    public IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        
    }

    public void NextSentences()
    {
        // continueButton.SetActive(false);
        
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

        // for(int i = 0 ; i < sentences.Length ; i++)
        // {
        //     image[i].gameObject.SetActive(false);
        //     image[index].gameObject.SetActive(true);
        // }
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
            Tutorial.SetActive(false);
            // continueButton.SetActive(false);
            girl.GetComponent<movement>().enabled = true;
            change_cam.GetComponent<Change_Camera>().enabled = true;
            girl.GetComponent<attack>().enabled = true;
            Demon.GetComponent<demon_movement>().enabled = false;
        }
    }

    public void Press()
    {
        // textDisplay.text = "";
        Tutorial.SetActive(false);
        // continueButton.SetActive(false);
        girl.GetComponent<movement>().enabled = false;
        change_cam.GetComponent<Change_Camera>().enabled = true;
        girl.GetComponent<attack>().enabled = false;
        Demon.GetComponent<demon_movement>().enabled = true;
        
        if(index < sentences.Length - 1)
        {
            index ++;
        }
            
    }

}
