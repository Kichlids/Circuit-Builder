using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    private Component[] components;


    public int currentLevel;
    public int farthestLevel;
    public List<bool> levelUnlocked = new List<bool>();

    private void Awake() {
        if (gameManager == null) {
            gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (gameManager != this) {
            Destroy(gameObject);
        }
    }

    private void Start() {
        levelUnlocked.Add(true);
        for (int i = 0; i < 9; i++) {
            levelUnlocked.Add(false);
        }
    }

    public void OnSceneInitialize() {
        components = Object.FindObjectsOfType<Component>();

        foreach (Component component in components) {
            component.valueInputField.text = "";
        }
    }

    public void OnSceneLoad(int level) {
        if (levelUnlocked[level - 1]) {
            print("Loading scene " + level);
            currentLevel = level;
            SceneManager.LoadScene("Level " + level, LoadSceneMode.Single);
        }
        else {
            print("Level locked");
        }
    }

    public bool OnCheckAnswer() {
        components = Object.FindObjectsOfType<Component>();

        foreach (Component component in components) {
            if (!component.Validate()) {
                return false;
            }
        }

        return true;
    }
}
