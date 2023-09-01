using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Camera : MonoBehaviour
{
    public GameObject Demon_Cam;
    public GameObject Girl_Cam;
    public GameObject Demon;
    public GameObject Girl;
    public bool Cam = false; //if cam false = demon, cam true = girl
    public InteractionSystem IS;
    public GameObject Demon_light;
    public GameObject Girl_light;
    public GameObject rb;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            if (Cam == false)
            {
                rb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
                Girl.GetComponent<attack>().enabled = true;
                Demon.GetComponent<demonattack>().enabled = false;
                Girl_Cam.SetActive(true);
                Demon_Cam.SetActive(false);
                Demon.GetComponent<demon_movement>().enabled = false;
                Girl.GetComponent<movement>().enabled = true;
                Cam = true;
                Demon_light.SetActive(false);
                Girl_light.SetActive(true);
                Demon.GetComponent<InteractionSystem>().enabled = false;
                Girl.GetComponent<InteractionSystem>().enabled = true;
                Demon.GetComponent<Follow_Girl>().enabled = true;
                Girl.GetComponent<Follow_Demon>().enabled = false;
                Demon.GetComponent<Collider2D>().enabled = false;

            }
            else
            {
                rb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                Girl.GetComponent<attack>().enabled = false;
                Demon.GetComponent<demonattack>().enabled = true;
                Girl_Cam.SetActive(false);
                Demon_Cam.SetActive(true);
                Demon.GetComponent<demon_movement>().enabled = true;
                Girl.GetComponent<movement>().enabled = false;
                Cam = false;
                Demon_light.SetActive(true);
                Girl_light.SetActive(false);
                Demon.GetComponent<InteractionSystem>().enabled = true;
                Girl.GetComponent<InteractionSystem>().enabled = false;
                Demon.GetComponent<Follow_Girl>().enabled = false;
                Girl.GetComponent<Follow_Demon>().enabled = true;
                Demon.GetComponent<Collider2D>().enabled = true;
            }
        }
    }

}