using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class joystickdrag : MonoBehaviour,IPointerDownHandler
{
    public Vector3 touchposition;
    public void OnPointerDown(PointerEventData eventData)
    {
        print("image is down");
        print(eventData.position);
        Vector3 touchposition = eventData.position;
    }
}
