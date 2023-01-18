using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    [SerializeField] private GameObject endGame;
    float size = 10;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided death!");

        if (collision.tag == "Zombie")
        {
            //Ending Code here
            size += 4 * Time.deltaTime;
            endGame.SetActive(true);
        }
    }
}
