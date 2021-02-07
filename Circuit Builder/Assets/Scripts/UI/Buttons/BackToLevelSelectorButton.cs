using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BackToLevelSelectorButton : MonoBehaviour
{
    private Button backButton;

    private void Start() {
        backButton = GetComponent<Button>();
        backButton.onClick.AddListener(OnBackToLevelSelector);
    }

    private void OnBackToLevelSelector() {
        SceneManager.LoadScene("Level Selector", LoadSceneMode.Single);
    }
}
