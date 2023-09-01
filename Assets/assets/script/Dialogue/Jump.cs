using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Jump : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public bool Movement;
    public GameObject InteractCheck;
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        StartCoroutine(Type()); //Start Dialogue 
    }

    void OnTriggerStay2D(Collider2D other) 
    {
        InteractCheck.SetActive(false);
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }   

    void OnTriggerExit2D(Collider2D other) 
    {   
        
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
    }

}