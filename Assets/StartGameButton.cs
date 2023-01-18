using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGameButton : MonoBehaviour
{

    public Button yourButton;

   
    public void LoadNextScene()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
