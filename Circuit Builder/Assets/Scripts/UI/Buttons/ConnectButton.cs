using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class ConnectButton : MonoBehaviour
{
    private Button connectButton;
    public RawImage background;
    public Texture bgDark;
    public Texture bgLight;

    private AudioSource audio;
    public AudioClip correct;
    public AudioClip incorrect;

    private void Start() {
        background = GameObject.FindGameObjectWithTag("Background").GetComponent<RawImage>();
        background.texture = bgDark;

        connectButton = GetComponent<Button>();
        connectButton.onClick.AddListener(OnConnect);

        audio = GetComponent<AudioSource>();
    }

    private void OnConnect() {
        if (GameManager.gameManager.OnCheckAnswer()) {
            print("Correct");

            audio.clip = correct;

            // Unlock next level
            int level = GameManager.gameManager.currentLevel;
            if (level < 10) {
                GameManager.gameManager.levelUnlocked[level] = true;
            }

            background.texture = bgLight;

            GameManager.gameManager.farthestLevel = Mathf.Max(GameManager.gameManager.farthestLevel, GameManager.gameManager.currentLevel);
        }
        else {
            print("Incorrect");
            audio.clip = incorrect;
        }

        audio.Play();
    }
}
