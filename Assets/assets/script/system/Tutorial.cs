using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Tutorial : MonoBehaviour
{
    public GameObject tutorialWindow;
    public GameObject exitButton;
    public GameObject[] Text;
    public GameObject[] Image;
    int index;
    public GameObject nextButton;
    public GameObject backButton;

    void Start()
    {
        index = 0;
    } 

    public void Tutorials() //เปิดหน้า UI
    {
        tutorialWindow.SetActive(true); //เปิดหน้า UI
        exitButton.SetActive(true); //เปิดปุ้ม exit
        Time.timeScale = 0; //หยุดเวลา
        if(index == 0)
        {
            Text[0].gameObject.SetActive(true);
            Image[0].gameObject.SetActive(true);
        }   
    }

    public void ExitButton() //ปิดหน้า UI
    {
        exitButton.SetActive(false); //ปิดปุ่ม exit
        tutorialWindow.SetActive(false); //ปิดหน้า UI
        Time.timeScale = 1; //ให้เวลาเดินต่อ
    }

    public void gonext() //ปุ่มไปหน้าต่อไป
    {
        index += 1; //เพิ่ม index ของ array
        for(int i = 0 ; i < Text.Length ; i++) //ตอนแรกให้ i เป็น 0 แล้วทำให้เอา text 1 มาใช้ หลังจากนั้นก็ค่อยๆเพิ่ม i ทำให้เอา text ที่เหลือมาใช้ได้
        {
            Text[i].gameObject.SetActive(false); //textที่ i เป็น false เช่น Text[0] = false
            Text[index].gameObject.SetActive(true); //ให้ text ที่ index เป็น true เช่น Text[1] = true
            backButton.SetActive(true); //ให้ back button เป็น true เพราะข้างล่างบอกว่า index ที่ 0 ให้ back button เป็น false

            Image[i].gameObject.SetActive(false);
            Image[index].gameObject.SetActive(true);
            backButton.SetActive(true);
        }
        if(index == Text.Length - 1) //ให้ตรวจหา index ล่าสุด(Length = len) len ของ list - 1
        {
            nextButton.SetActive(false); //ให้ next button เป็น false เพื่อไม่ให้ index out of range
        }
    }

    public void goback() //ปุ่มกลับหน้าก่อนหน้า
    {
        index -= 1; //index - 1
        for(int i = 0; i < Text.Length ; i++) //เหมือน gonext แค่ตรงกันข้าม
        {
            Text[i].gameObject.SetActive(false);
            Text[index].gameObject.SetActive(true);
            nextButton.SetActive(true);

            Image[i].gameObject.SetActive(false);
            Image[index].gameObject.SetActive(true);
            nextButton.SetActive(true);
        }
        if(index == 0) //ถ้าเป็นหน้าแรกให้ปิดปุ่ม back ไว้ ไม่ให้ index ติดลบ
        {
            backButton.SetActive(false);
        }
    }
}
