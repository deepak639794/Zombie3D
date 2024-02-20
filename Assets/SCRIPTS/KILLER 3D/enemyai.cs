using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyai : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;
    private float Zomview=360;
    private float ZomRange = 150;
    public float zombieDis;

    //some booliens//
    public bool ZombieVision;
    //public bool ZombieActive;




    // Update is called once per frame
    void Update()
    {
        Vector3 zombiedirection = target.position - transform.position;
       
        float zombieangle = Vector3.Angle(transform.forward, zombiedirection);
         zombieDis = Vector3.Distance(transform.position, target.position);
        
        
        if (zombieangle <= Zomview && zombieDis <= ZomRange)
        {
            ZombieVision = true;
        }
        else
        {
           ZombieVision = false;
        }
        
        if (ZombieVision == true)
        {
            ZombieActive();
        }
        
        
       
        
    }
    public void ZombieActive()
    {
        agent.SetDestination(target.position);
    }
}
