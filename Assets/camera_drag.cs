using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class camera_drag : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
   
    public Image move_background;
    public Image move_handel;
    public Vector2 inputvector;
   // public Camera cam_transform;
   // public GameObject gameobject;
    public void OnPointerDown(PointerEventData eventData)
    {
       

    }
    public void OnPointerUp(PointerEventData eventData)
    {

        move_handel.rectTransform.anchoredPosition = new Vector2(0, 0);
    }
    public void OnDrag(PointerEventData eventData)
    {

        Vector2 pos = Vector2.zero;
        float BGsizeY = move_background.rectTransform.sizeDelta.y;
        float BGsizeX = move_background.rectTransform.sizeDelta.x;

        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(move_background.rectTransform
                                                                    , eventData.position
                                                                    , eventData.pressEventCamera
                                                                    , out pos))
        {
            
            pos.x /= BGsizeX;
            pos.y /= BGsizeY;
            
            inputvector = new Vector2(pos.x, pos.y);
           
            inputvector = (inputvector.magnitude > 0.5f) ? inputvector.normalized : inputvector;
            move_handel.rectTransform.anchoredPosition = new Vector2(inputvector.x * BGsizeX / 2, inputvector.y * BGsizeY / 2);
           
        }
    }
    
}
