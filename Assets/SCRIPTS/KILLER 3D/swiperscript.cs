using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swiperscript : MonoBehaviour
{
    public Camera cam;
    private Vector3 orirot;
    public float dir = -1;
    public float rotspeed = 1f;
    private float rotX;
    private float rotY;
    private Touch initTouch;
    // Start is called before the first frame update
    void Start()
    {
        orirot = cam.transform.eulerAngles;

        rotX = orirot.x;
        rotY = orirot.y;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {

                initTouch = touch;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                float deltaY = initTouch.position.x - touch.position.x;
                float deltaX = initTouch.position.y - touch.position.y;
                rotX -= deltaX * Time.deltaTime * rotspeed * dir;
                rotY -= deltaY * Time.deltaTime * rotspeed * -dir;

                cam.transform.eulerAngles = new Vector3(rotX, rotY, 0);
            }
        }
    }
}
