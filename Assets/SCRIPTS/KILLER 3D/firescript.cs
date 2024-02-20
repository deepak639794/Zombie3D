using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class firescript : MonoBehaviour,IPointerUpHandler,IPointerDownHandler
{
    public bool pressed;
    
    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
    }
}
