using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JUMP : MonoBehaviour, IPointerDownHandler
{
    public Rigidbody plrigidbody;
    public Transform pltransform;
    public float jmpforce;

    public void OnPointerDown(PointerEventData eventData)
    {
        print("jump");
        plrigidbody.AddForce(pltransform.up*jmpforce);
    }
   
}
