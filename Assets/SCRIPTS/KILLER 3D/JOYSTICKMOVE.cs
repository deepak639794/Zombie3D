using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JOYSTICKMOVE : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IDragHandler
{
    public Image joybackground;
    public Image joyhandel;
    public Vector3 inputvector;
    public joystickdrag Joystickdrag;
    public Transform transform;

    public void OnDrag(PointerEventData eventData)
    {       
        Vector2 pos = Vector2.zero;
        float BGsizeX = joybackground.rectTransform.sizeDelta.x;
        float BGsizeY = joybackground.rectTransform.sizeDelta.y;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(joybackground.rectTransform
                                                                    ,eventData.position
                                                                    ,eventData.pressEventCamera
                                                                    ,out pos))
        {
            pos.x /= BGsizeX;
            pos.y /= BGsizeY;
             inputvector = new Vector2(pos.x, pos.y);
            inputvector = (inputvector.magnitude > 1f) ? inputvector.normalized : inputvector;
            joyhandel.rectTransform.anchoredPosition = new Vector2(inputvector.x * BGsizeX/2, inputvector.y* BGsizeY/2);
        }

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        //transform.position =Joystickdrag.touchposition;
        OnDrag(eventData);
    }
   public void OnPointerUp(PointerEventData eventData)
    {
        inputvector = new Vector3(0, 0, 0);
        joyhandel.rectTransform.anchoredPosition = new Vector3(0, 0, 0);
    }
    
}
