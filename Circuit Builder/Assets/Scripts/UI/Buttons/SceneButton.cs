using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SceneButton : MonoBehaviour
{
    private Button sceneButton;
    public int level;

    private void Start() {
        sceneButton = GetComponent<Button>();
        sceneButton.onClick.AddListener(OnClick);
    }

    private void OnClick() {
        GameManager.gameManager.OnSceneLoad(level);
    }
}
