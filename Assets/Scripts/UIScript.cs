using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public string OyunSahnesi;
    public string AnaSahne;
 
    public void StartGame()
    {
        SceneManager.LoadScene(OyunSahnesi);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void GeriDon()
    {
        SceneManager.LoadScene(AnaSahne);
    }
}
