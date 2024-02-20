using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraGO : MonoBehaviour
{
    public camera_drag Camera_Drag;
    public float sensitivity;
    // Update is called once per frame
    void Update()
    {
             transform.localRotation = Quaternion.Euler(0,Camera_Drag.inputvector.x * sensitivity, 0f);
    }
}
