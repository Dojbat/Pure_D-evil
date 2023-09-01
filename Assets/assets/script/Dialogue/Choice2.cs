using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Choice2 : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public float typingSpeed;
    public string[] choices;
    private int index;
    public GameObject C;
    private bool select;
    public Dialogue x;
    private bool y;


    void Update()
    {
        
        if(x.Select_Sentence_Index[x.Index] == x.index) // Check Dialogue Index
        {
            if(y == false) // ไม่ให้พิมพ์ซ้ำ
            {
                if(x.textDisplay.text == x.sentences[x.index])
                {
                    C.SetActive(true);
                    StartCoroutine(Type());
                    y = true;
                }
            }
        }

        if(x.index != x.Select_Sentence_Index[x.Index])
            {
                Text.text = "";
                C.SetActive(false);
                y = false;
            }

        // if(x.index == x.Select_Sentence_Index[x.Index] + 1)
        // {
        //     x.Index += 1;
        //     index += 1;
        // }
    }

    public void GetClick()
    {
        x.sentences[x.Select_Sentence_Index[x.Index] + 1] = "Demon : " + choices[x.Cindex];
        x.NextSentences();
        C.SetActive(false);
    }

    IEnumerator Type()
    {
        foreach(char letter in choices[x.Cindex].ToCharArray())
        {
            Text.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

}
