using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchControl : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public Transform Player;
    public void OnBeginDrag(PointerEventData eventData)
    {
        if(Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
        {
            if (eventData.delta.x > 0)
            {
                Player.transform.Rotate(0, 0, 90);
            }
            else 
            {
                //Player.transform.rotation = Quaternion.Euler(90, -90, 0);
                Player.transform.Rotate(0, 0, -90);
            }
        }
    }
    public void OnDrag(PointerEventData eventData)
    {

    }
}
