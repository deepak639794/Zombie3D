using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zombieanimations : MonoBehaviour
{
    public Animator anim;
    public enemyai Z_ai_script;
    public GameObject image;
    public weaponshooter Weaponshooter;
    float next_attack = 0;
    public healthslider playerslider;


    // Update is called once per frame
    void Update()
    {

        if (Z_ai_script.ZombieVision == false)
        {
            image.SetActive(false);
            anim.SetBool("idle", true);
            //anim.SetBool("reaction ", false);
            anim.SetBool("run", false);
            anim.SetBool("attack", false);
            

        }
        else
        {
            if (Z_ai_script.zombieDis >4f)
            {
               
                image.SetActive(false);
                anim.SetBool("idle", false);
                //anim.SetBool("reaction ", false);
                anim.SetBool("run", true);
                anim.SetBool("attack", false);
            }
            else
            {
                
               
                
                if (Time.time >= next_attack)
                {
                    next_attack = Time.time + 2f;
                    playerslider.Sethealth(1f);
                    
                }
                image.SetActive(true);
                anim.SetBool("idle", false);
                //anim.SetBool("reaction ", true);
                anim.SetBool("run", false);
                anim.SetBool("attack", true);
               
            }
            
        }
    }
       
}
