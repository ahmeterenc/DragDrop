using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public GameObject gamePanel;
    public GameObject homePanel;
 
    public void StartGame()
    {
        gamePanel.SetActive(true);
        homePanel.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void GeriDon()
    {
        homePanel.SetActive(true);
        gamePanel.SetActive(false);
    }
}
