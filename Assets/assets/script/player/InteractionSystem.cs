    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    using TMPro;

    public class InteractionSystem : MonoBehaviour
    {
        [Header("Detection Fields")]
        //Detection Point
        public Transform detectionPoint;
        //Detection Radius
        private const float detectionRadius = 0.2f;
        //Detection Layer
        public LayerMask detectionLayer;
        //Cached Trigger Object
        public GameObject detectedObject;
        [Header("Examine Fields")]
        //Examine window object
        public GameObject examineWindow;
        public Image examineImage;
        public Text examineText;
        public bool isExamining;



        void Update()
        {
            if(DetectObject())
            {
                if(InteractInput())
                {
                    detectedObject.GetComponent<Item>().Interact();
                }
            }
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(detectionPoint.position, detectionRadius);
        }

        bool InteractInput()
        {
            return Input.GetKeyDown(KeyCode.E);
        }

        bool DetectObject()
        {        
                    
            Collider2D obj = Physics2D.OverlapCircle(detectionPoint.position,detectionRadius,detectionLayer); 
            
            if(obj==null)
            {
                detectedObject = null;
                return false;
            }
            else
            {
                detectedObject = obj.gameObject;
                return true;
            }
        }
        

        public void ExamineItem(Item item)
        {
            if (isExamining)
            {   
                //Hide ExamineWindow
                examineWindow.SetActive(false); 
                //Disable the boolean
                isExamining = false;
                Time.timeScale = 1;
            
            }
            else
            {
                Time.timeScale = 0;
                //Display an Examine Window
                examineImage.sprite = item.GetComponent<SpriteRenderer>().sprite;
                //Show the item's image in the middle
                examineText.text = item.descriptionText;
                //Write description text underneath the image
                examineWindow.SetActive(true); 
                //Eneble boolean
                isExamining = true;
            }
            
            

        }
    }