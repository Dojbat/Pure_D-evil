using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler {
	public GameObject canvas;
	// public GameObject text;
	
	
	public static bool checkitem1;

	[Header("GameObejct")]
	public GameObject item1;
	public GameObject item2;
	public GameObject item3;
	
	Vector3 StartPoint;

	void Awake() 
	{
		StartPoint = transform.position;
	}

	void comein()
	{
		if(DragHandeler.itemBeingDragged.tag == "Puzzle_Answer")
		{
			checkitem1 = true;
		}
		else
		{
			checkitem1 = false;
		}
	}
	public GameObject item {
		get {
			if(transform.childCount>0){
				return transform.GetChild (0).gameObject;
			}
			return null;
		}
	}

	

	public void Correct()
	{
		if(checkitem1 == true)
		{
			Time.timeScale = 1;
			canvas.SetActive(false);
			// text.SetActive(true);
		}
		else
		{
			Debug.Log("Incorrect Try Agian");
		}
	}

	#region IDropHandler implementation
	public void OnDrop (PointerEventData eventData)
	{
		if(!item)
		{
			DragHandeler.itemBeingDragged.transform.SetParent (transform);
			// Debug.Log(DragHandeler.itemBeingDragged);
			comein();
		}
		
	}
	#endregion
}
