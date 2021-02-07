using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BackToMenuButton : MonoBehaviour {
    private Button backButton;

    private void Start() {
        backButton = GetComponent<Button>();
        backButton.onClick.AddListener(OnBackToMenu);
    }

    private void OnBackToMenu() {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
