using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public void OnPlayButton() {
        SceneManager.LoadScene("Level Selector", LoadSceneMode.Single);
    }

    public void OnQuitButton() {
        Application.Quit();
    }
}
