using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_rotation : MonoBehaviour
{
    public camera_drag Camera_Drag;
    public float sensitivity;
    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(Camera_Drag.inputvector.y*sensitivity, 0f, 0f);
    }
}
