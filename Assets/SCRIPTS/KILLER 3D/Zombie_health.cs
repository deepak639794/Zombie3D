using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_health : MonoBehaviour
{
    public float currenthealth;
    public float health = 100;
    
   
    void Start()
    {
        currenthealth = health;
    }
    public void Damage(float Zhealth)
    {
        
        currenthealth -= Zhealth;
        
    }
    

}
