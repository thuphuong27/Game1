using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotsManagerCollider : MonoBehaviour
{
    public GameObject plant;
    public bool isOccupied = false;
    public bool isfull;
    public GameManager gameManager;
    public Image backgroundImage;
    private void Start()
    {
        gameManager = GameManager.instance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameManager.draggingObject != null && isfull == false)
        {
            gameManager.currentContainer = this.gameObject;
            backgroundImage.enabled = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        gameManager.currentContainer = null;
        backgroundImage.enabled = false;
    }
    void OnMouseOver()
    {
        foreach (CardManager item in GameObject.FindObjectsOfType<CardManager>())
        {
            item.colliderName = this.GetComponent<SlotsManagerCollider>();
            item.isOverCollider = true;
        }

        if (plant == null)
        {
            if (GameObject.FindGameObjectWithTag("Plant") != null)
            {
                plant = GameObject.FindGameObjectWithTag("Plant");
                plant.transform.SetParent(this.transform);
                Vector3 pos = new Vector3(0, 0, -1);
                plant.transform.position = new Vector3(0, 0, -1);
                plant.transform.localPosition = pos;
            }
        }
        else
        {
            isOccupied = false;
        }
    }

    private void OnMouseExit()
    {
        //Destroy(plant);
    }
}
