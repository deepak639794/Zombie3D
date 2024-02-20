using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class playermovement : MonoBehaviour
{
    public CharacterController characterController;
    public float movespeed = 2f;
    public GameObject gameObject;
    
    public JOYSTICKMOVE joystick;
    //public Rigidbody rb;
    
    public Vector2 dirn;
    void Update()
    {
        dirn.x = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;
        dirn.y = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        
        dirn = new Vector2(joystick.inputvector.x, joystick.inputvector.y);


        //rb.AddForce(dirn.y*movespeed,0,-dirn.x*movespeed);
        characterController.Move(gameObject.transform.right * dirn.x*-movespeed);
       characterController.Move(gameObject.transform.forward * dirn.y*-movespeed);
        

    }
   
}
