using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour{
    
    public void LoadNextScreen() {
        int cur = SceneManager.GetActiveScene().buildIndex;
        if(cur == 2) {
            SceneManager.LoadScene(0);
        }
        else {
            SceneManager.LoadScene(cur + 1);
        }
    }

    public void QuitGame() => Application.Quit();
}
