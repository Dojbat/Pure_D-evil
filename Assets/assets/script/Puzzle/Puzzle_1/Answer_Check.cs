using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer_Check : MonoBehaviour
{
    bool Check;
    void Correct()
    {
        if(gameObject.tag == "Puzzle_Answer")
        {
            Debug.Log("Close");
        }   
    }
}
