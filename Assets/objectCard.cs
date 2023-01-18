using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class objectCard : MonoBehaviour,IDragHandler,IPointerDownHandler,IPointerUpHandler
{

    public GameObject object_Drag;
    public GameObject object_Game;
    public Canvas canvas;
    private GameObject object_Drag_Instance;

    public void OnDrag(PointerEventData eventData)
    {
        object_Drag_Instance.transform.position = Input.mousePosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        object_Drag_Instance= Instantiate(object_Drag, canvas.transform);
        object_Drag_Instance.transform.position = Input.mousePosition;

        GameManager.instance.draggingObject = object_Drag_Instance;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        GameManager.instance.draggingObject = null;
        //Destroy(object_Drag_Instance);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
