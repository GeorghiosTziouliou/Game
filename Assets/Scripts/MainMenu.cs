using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void Play()
   {
      Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
   
   public void BackMainMenu()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
   }

   public void Quit()
   {
      Application.Quit();
   }
}
