using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Stats;
using UnityEngine.SceneManagement;

namespace RPG.UI
{
    public class PauseGame : MonoBehaviour
{
    public bool Paused = false;
   
    public GameObject PauseMenu;

	void Update () {
		if (Input.GetButtonDown("Cancel"))
        {
            if (Paused == false)
            {
                Time.timeScale = 0;
                Paused = true;
                PauseMenu.SetActive(true);
                
                
            }

            else
            {
               
                Paused = false;
                PauseMenu.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
        

        public void NewGameScene()
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
        }

        public void MainMenuScene()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }

        public void UnpauseGame()
        {

            Paused = false;
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
        }

        public void doQuit()
        {
            Application.Quit();
            Time.timeScale = 1;
        }

}
}

