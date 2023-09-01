using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Go_back : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string[] message;
    private int index;
    public float typingSpeed;

    void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.tag == "Girl")
        {
            StartCoroutine(Type());
            index += 1;
        }
        else
        {
            text.text = "";
        }
    }
    void OnTriggerExit2D(Collider2D collision) 
    {
        if(collision.gameObject.tag == "Girl")
        {
            text.text = "";
        }
    }

    IEnumerator Type()
    {
        foreach(char letter in message[index].ToCharArray())
        {
            text.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        
    }
    void Update()
    {
        if(index == message.Length)
        {
            index = 0;
        }
    }

}
