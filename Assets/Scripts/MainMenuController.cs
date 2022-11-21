using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
  public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

  public void OpenAuthor()
    {
        Debug.Log("Created by Abraham April Triesnady");
    }
  
    public void Credit()
    {
        Debug.Log("Nama lengkap  : Abraham April Triesdnady");
        Debug.Log("https://github.com/Simple-man54?tab=repositories");
    }
}
