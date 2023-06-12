using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Oyun sahnesine geçildi.");
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Oyundan çýkýldý.");
    }
}
