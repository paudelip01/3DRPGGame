using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RPG.UI
{

    public class MainMenuUI : MonoBehaviour
    {
        // Start is called before the first frame update
        

        public void NewGameScene()
        {
            SceneManager.LoadScene(1);
        }

        public void doQuit()
        {
            Application.Quit();
        }
    }

}