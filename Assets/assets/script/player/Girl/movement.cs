using UnityEngine;

public class movement : MonoBehaviour
{
    public float originspeed = 5f;
    public float MovementSpeed = 1f;
    public float originjump;
    public float JumpForce;
    public float Jumpboost;
    public Animator animator2D;
    public float MoveX;
    float Horizontal_Move = 0f;
    public bool controling = true;
    public GameObject Gamemanager;
    public ground_check Ground; 
    public AudioSource walk;
    public AudioSource jump;
    

    SavePlayerPos playerPosData;
 
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        JumpForce = originjump;
        Jumpboost = originjump + 5;
        // if(Mainmanu.start == true)
        // {
        //     playerPosData = FindObjectOfType<SavePlayerPos>();
        //     playerPosData.PlayerPosLoad(); 
        // }
    }

    void Start()
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


        if(Ground.ground == false)
        {
            animator2D.SetBool("Is walk", false);
            animator2D.SetBool("Is jump" , true);
            walk.enabled = false;
        }

        else if(MoveX == 1||MoveX == -1 && Ground.ground == true)
        {
                animator2D.SetBool("Is walk", true);
                animator2D.SetBool("Is jump" , false);
                walk.enabled = true;
        }
        
        // else if(Ground.ground == false)
        // {
        //     animator2D.SetBool("Is walk", false);
        //     animator2D.SetBool("Is jump" , true);
        // }

        else
        {
            walk.enabled = false;
            animator2D.SetBool("Is walk", false);
            animator2D.SetBool("Is jump", false);
        }

        if(Ground.ground == true)
        {
            jump.enabled = false;
        }

        if (controling == true)
        {
            if (!Mathf.Approximately(0,MoveX))
            {
                transform.rotation = MoveX > 0 ? Quaternion.Euler(0, -180, 0) : Quaternion.identity;
            }
            if(Input.GetButtonDown("Jump") && Ground.ground == true)
            {
                _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
                jump.enabled = true;
            }
        }

        if(Ground.green == true)
        {
            JumpForce = Jumpboost;
        }
        else
        {
            JumpForce = originjump;
        }
    }


    // void OnTriggerExit2D (Collider2D col)
    // {
    //     if(col.gameObject.tag == "green")
    //     {
    //         JumpForce = originjump;
    //         Ground.ground = false;
    //     }
    // }
}
