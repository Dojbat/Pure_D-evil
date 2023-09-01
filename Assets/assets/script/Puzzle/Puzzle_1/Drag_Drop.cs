using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag_Drop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    // [SerializeField]
    // private Canvas canvas;
    // private RectTransform rectTransform;
    // private CanvasGroup canvasGroup;

    public GameObject canvas;
    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       itemBeingDragged = null;
       GetComponent<CanvasGroup>().blocksRaycasts = true;
       if(transform.parent == startParent)
       {
        transform.position = startPosition;
       }
       
    }

    public void OnDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }


    // public void DargHandler(BaseEventData data)
    // {
    //     PointerEventData pointerData = (PointerEventData)data;

    //     Vector2 position;
    //     RectTransformUtility.ScreenPointToLocalPointInRectangle(
    //         (RectTransform)canvas.transform,
    //         pointerData.position,
    //         canvas.worldCamera,
    //         out position);
        
    //     transform.position = canvas.transform.TransformPoint(position);
    // }

    

}
