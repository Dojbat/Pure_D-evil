using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demon_movement : MonoBehaviour
{
 public float originspeed = 5f;
    public float MovementSpeed = 1f;
    public float JumpForce = 1;
    public Animator animator2D;
    public float MoveX;
    float Horizontal_Move = 0f;
    public bool controling = true;
    public GameObject Gamemanager;
    

    SavePlayerPos playerPosData;
 
    private Rigidbody2D _rigidbody;

    // private void Awake()
    // {
    //     if(Mainmanu.start == true)
    //     {
    //         playerPosData = FindObjectOfType<SavePlayerPos>();
    //         playerPosData.PlayerPosLoad(); 
    //     }
    // }

    void Awake()
    {
        
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        MoveX = Input.GetAxisRaw("Horizontal"); //GetInput A,D
        Horizontal_Move = MoveX * MovementSpeed; 
        animator2D.SetFloat("Speed", Mathf.Abs(Horizontal_Move));
        if(MoveX == 1||MoveX == -1)
        {
            animator2D.SetBool("Is walk", true);
        }
        else if(Mathf.Abs(_rigidbody.velocity.y) > 0)
        {
            animator2D.SetBool("Is jump", true);
        }

        else
        {
            animator2D.SetBool("Is walk", false);
            animator2D.SetBool("Is jump", false);
        }


        if (controling == true)
        {
            if (!Mathf.Approximately(0,MoveX))
            {
                transform.rotation = MoveX > 0 ? Quaternion.Euler(0, -180, 0) : Quaternion.identity;
            }
            if(Input.GetButtonDown("Jump")) //&& Mathf.Abs(_rigidbody.velocity.y) < 0.000001f)
            {
                _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            }
        }
    }
}
