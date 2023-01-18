using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PauseGame : MonoBehaviour
{
    // Start is called before the first frame update

    public UnityEngine.UI.Button myButton;
    public GameObject pausePanel;
    public GameManager gameManager;
   public void pauseGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        
    }
    public void BackToGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    } 
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    
}
