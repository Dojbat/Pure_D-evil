using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_shoot : MonoBehaviour
{
    public float forces;
    public GameObject bullet;
    public Transform self; 

    void Start()
    {

    }

    void Awake()
    {

    }

    void Update()
    {
        
    }

    public void Shoot()
    {
        GameObject shoot = Instantiate(bullet,self.position,self.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(self.right * forces, ForceMode2D.Impulse);
    }
}
