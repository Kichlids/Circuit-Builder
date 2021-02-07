using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectorUI : MonoBehaviour
{
    public GameObject[] levelSelectorButtons;

    private void Start() {
        levelSelectorButtons = GameObject.FindGameObjectsWithTag("LevelSelectorButton");
    }

    private void Update() {

        for (int i = 0; i < GameManager.gameManager.farthestLevel; i++) {
            Button b1 = levelSelectorButtons[i].GetComponent<Button>();
            ColorBlock cb1 = b1.colors;
            cb1.normalColor = Color.green;
            b1.colors = cb1;
        }

        Button b2 = levelSelectorButtons[GameManager.gameManager.farthestLevel].GetComponent<Button>();
        ColorBlock cb2 = b2.colors;
        cb2.normalColor = Color.white;
        b2.colors = cb2;

        for (int i = GameManager.gameManager.farthestLevel + 1; i < 10; i++) {
            Button b3 = levelSelectorButtons[i].GetComponent<Button>();
            ColorBlock cb3 = b3.colors;
            cb3.normalColor = Color.red;
            b3.colors = cb3;
        }
    }
}
