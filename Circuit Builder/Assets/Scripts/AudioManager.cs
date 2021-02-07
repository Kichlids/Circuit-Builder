using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    private AudioSource audio;

    public AudioClip MenuMusic;
    public AudioClip gameMusic;

    private bool wasInMenu = true;
    private bool inMenu = true;

    private void Start() {
        audio = GetComponent<AudioSource>();
        audio.clip = MenuMusic;
        audio.Play();
    }

    private void Update() {
        string sceneName = SceneManager.GetActiveScene().name;

        if (sceneName == "Menu" || sceneName == "Level Selector") {
            inMenu = true;
        }
        else {
            inMenu = false;
        }

        if (wasInMenu == inMenu) {
            // still in menu
        }
        else {
            if (inMenu) {
                audio.clip = MenuMusic;
            }
            else {
                audio.clip = gameMusic; 
            }
            wasInMenu = inMenu;
            audio.Play();
        }
    }


}
