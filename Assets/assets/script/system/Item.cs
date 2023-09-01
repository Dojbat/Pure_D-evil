using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class Item : MonoBehaviour
{    
    public enum InteractionType { NONE, PickUp, Examine}
    public InteractionType type;
    [Header("Examine")]
    public string descriptionText;



    private void Reset()
    {
        GetComponent<Collider2D>().isTrigger = true;
        gameObject.layer = 10;
    }

    public void Interact()
    {
        switch(type)
        {
            case InteractionType.PickUp:
            //Add the object to the PickedUpItems list
            FindObjectOfType<Inventory_System>().PickUp(gameObject);
            //Disable
            gameObject.SetActive(false);
            break;
            case InteractionType.Examine:
            //all the Examine item in the interaction system
            FindObjectOfType<InteractionSystem>().ExamineItem(this);
            break;
            default:
            Debug.Log("NULL ITEM");
            break;
        }


    }
}