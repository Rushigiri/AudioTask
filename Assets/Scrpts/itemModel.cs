using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public enum ItemType
{
    Food,
    Accessory,
    Trekking
}



public class itemModel : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IDragHandler
{

    public ItemsManager.ItemType type;

    
    public void OnDrag(PointerEventData eventData)
    {
        
       // Debug.Log("drag success");
        transform.position = eventData.position;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
       // Debug.Log("down");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("up");

    }
    private void Update()
    {
      /*  if (type.CompareTo()
        {

        }*/
    }
   





    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
