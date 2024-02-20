using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;




public class movementscript : MonoBehaviour, IPointerUpHandler,IPointerDownHandler
{
    public bool pressed;
    
    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
        //print(pressed);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
        //print(pressed);
    }

}
