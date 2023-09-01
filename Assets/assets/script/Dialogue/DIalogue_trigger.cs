using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIalogue_trigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject vistualCue;
    private bool playerInRange;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;


    private void Awake()
    {
        playerInRange = false;
        vistualCue.SetActive(false);

    }

    private void update()
    {
        if (playerInRange)
        {
            vistualCue.SetActive(true);
        }    
        else
        {
            vistualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
        

    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        playerInRange = false;

    }
}
