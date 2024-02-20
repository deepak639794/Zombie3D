using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform playertransform;
    public Vector3 offset;

    void Update()
    {
        transform.position = playertransform.position - offset;
    }
}
