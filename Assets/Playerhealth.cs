using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhealth : MonoBehaviour
{
    public float Pcurrenthealth;
    public float P_health = 100;
    public Rigidbody rb;
    

   
    void Start()
    {
        Pcurrenthealth = P_health;
    }
    public void Damage(float P_health)
    {
        Pcurrenthealth -= P_health;
        
    }
    void Update()
    {
        if (Pcurrenthealth == 0)
        {
            print("player is dead");
            rb.velocity = new Vector3(0,0,0);
        }

    }
    public void destroy()
    {

        Destroy(gameObject);

    }

}
