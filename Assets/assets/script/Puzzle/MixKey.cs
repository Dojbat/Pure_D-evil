using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MixKey : MonoBehaviour
{
    public GameObject UI;
    public player_stat stat;
    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public Sprite Plate1;
    public Sprite Plate2;
    public Sprite Plate3;
    public Sprite Red;
    public Sprite Blue;
    public Sprite Green;
    public Sprite Orange;
    public Sprite Yellow;
    public Sprite Purple; 
    public GameObject Door;
    public int freeze;
    public Animator anim;
    bool x = false;
    bool y = false;
    bool z = false;
    public bool b = false;
    public bool p = false;
    public bool g = false;


    void Awake()
    {
        freeze = stat.MP;
        Time.timeScale = 0;
    }

    void Update()
    {
        stat.MP = freeze;
        if(C1.GetComponent<Image>().sprite == Blue)
        {
            b = true;
        }
        else
        {
            b = false;
        }

        if(C2.GetComponent<Image>().sprite == Purple)
        {
            p = true;
        }
        else
        {
            p = false;
        }

        if(C3.GetComponent<Image>().sprite == Green)
        {
            g = true;
        }
        else
        {
            g = false;
        }

        if(x == true && y == true && z == true)
        {
            if(b == true && p == true && g == true)
            {
                Time.timeScale = 1;
                anim.enabled = true;
                Invoke("complete" , 6.0f);
            }
            else
            {
                wrong();
            }
        }
    }

    public void Getclick1()
    {
        x = true;
        if(stat.color == "red")
        {
            C1.GetComponent<Image>().sprite = Red; 
            Debug.Log("Change");
        }

        if(stat.color == "blue")
        {
            C1.GetComponent<Image>().sprite = Blue; 
            stat.color_clear();
            b = true;
            Debug.Log("Change");
        }

        if(stat.color == "yellow")
        {
            C1.GetComponent<Image>().sprite = Yellow; 
            stat.color_clear();
            Debug.Log("Change");
        }

        if(stat.color == "green")
        {
            C1.GetComponent<Image>().sprite = Green; 
            stat.color_clear();
            Debug.Log("Change");
        }

        if(stat.color == "orange")
        {
            C1.GetComponent<Image>().sprite = Orange; 
            stat.color_clear();
            Debug.Log("Change");
        }

        if(stat.color == "purple")
        {
            C1.GetComponent<Image>().sprite = Purple; 
            stat.color_clear();
            Debug.Log("Change");
        }
        stat.color_clear(); 
    }
    
    public void Getclick2()
    {
        y = true;
        if(stat.color == "red")
        {
            C2.GetComponent<Image>().sprite = Red; 
            Debug.Log("Change");
        }

        if(stat.color == "blue")
        {
            C2.GetComponent<Image>().sprite = Blue; 
            stat.color_clear();
            Debug.Log("Change");
        }

        if(stat.color == "yellow")
        {
            C2.GetComponent<Image>().sprite = Yellow; 
            stat.color_clear();
            Debug.Log("Change");
        }

        if(stat.color == "green")
        {
            C2.GetComponent<Image>().sprite = Green; 
            stat.color_clear();
            Debug.Log("Change");
        }

        if(stat.color == "orange")
        {
            C2.GetComponent<Image>().sprite = Orange; 
            stat.color_clear();
            Debug.Log("Change");
        }

        if(stat.color == "purple")
        {
            C2.GetComponent<Image>().sprite = Purple; 
            stat.color_clear();
            Debug.Log("Change");
            p = true;
        }
        stat.color_clear();  
    }

    public void Getclick3()
    {
        z = true;
        if(stat.color == "red")
        {
            C3.GetComponent<Image>().sprite = Red; 
            Debug.Log("Change");
        }

        if(stat.color == "blue")
        {
            C3.GetComponent<Image>().sprite = Blue; 
            stat.color_clear();
            Debug.Log("Change");
        }

        if(stat.color == "yellow")
        {
            C3.GetComponent<Image>().sprite = Yellow; 
            stat.color_clear();
            Debug.Log("Change");
        }

        if(stat.color == "green")
        {
            C3.GetComponent<Image>().sprite = Green; 
            stat.color_clear();
            Debug.Log("Change");
            g = true;
        }

        if(stat.color == "orange")
        {
            C3.GetComponent<Image>().sprite = Orange; 
            stat.color_clear();
            Debug.Log("Change");
        }

        if(stat.color == "purple")
        {
            C3.GetComponent<Image>().sprite = Purple; 
            stat.color_clear();
            Debug.Log("Change");
        }
        stat.color_clear();  
    }

    public void complete()
    {
        if(b == true && p == true && g == true)
            {
                Debug.Log("Correct");
                UI.SetActive(false);
                Time.timeScale = 1;
                Door.SetActive(false);
            }
    }

    public void wrong()
    {
        Time.timeScale = 0;
        C1.GetComponent<Image>().sprite = Plate1;
        C2.GetComponent<Image>().sprite = Plate2;
        C3.GetComponent<Image>().sprite = Plate3;
        x = false;
        y = false;
        z = false;
        b = false;
        p = false;
        g = false;
    }
            
}
