using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text sunDisp;
    public int startingSunAmnt;
    public int SunAmount = 0;
    

    public GameObject decorativeZombies;

    public Transform cardSlotsHolder;

    public ZombieManager zombieManager;
    public static GameManager instance;
    public GameObject draggingObject;
    public GameObject currentContainer;
    

    public Animator cameraPan;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        CardManager.isGameStart = false;
        AddSun(startingSunAmnt);
    }
    public void StartMatch()
	{
        cameraPan.SetTrigger("PanToPlants");
        CardManager.isGameStart = true;
        RefreshAllPlantCards();
        zombieManager.SpawnZombies();
	}

    public void AddSun(int amnt)
    {
        SunAmount += amnt;
        sunDisp.text = "" + SunAmount;
    }

    public void DeductSun(int amnt)
    {
        SunAmount -= amnt;
        sunDisp.text = "" + SunAmount;
    }

    public void RefreshAllPlantCards()
	{
        foreach (Transform card in cardSlotsHolder)
        {
            try
            {
                card.GetComponent<CardManager>().StartRefresh();
            }
            catch (System.Exception)
            {
                Debug.LogError("Card does not contain CardManager script!");
            }
        }
    }
}
