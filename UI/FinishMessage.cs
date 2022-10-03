using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace RPG.UI
{
    public class FinishMessage : MonoBehaviour
{
    public GameObject popUp;

    void Start()
    {
        popUp.SetActive(false);
    }

    void OnTriggerEnter(Collider Player) {

        if (Player.gameObject.tag == "Player")
        {
            popUp.SetActive(true);
            Time.timeScale = 0;

        }
        
    }

        public void MainMenuScene()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;

        }

        public void doQuit()
        {
            Application.Quit();
        }
}
}
