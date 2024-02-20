using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerarotation : MonoBehaviour
{

    public float sensitivity;
    public Transform player;

    private float rot;

   
    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
        float x=Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        float y= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        rot -= y;
        rot = Mathf.Clamp(90f, -90f, rot);
        //transform.localRotation = Quaternion.Euler(rot, 0f, 0f);
        //transform.Rotate(transform.right * y);
        player.Rotate(player.right * x);
        //player.Rotate(player.up * x);
    }
}
