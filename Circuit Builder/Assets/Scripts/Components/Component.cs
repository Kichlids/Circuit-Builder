using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Component : MonoBehaviour
{
    public TMP_InputField valueInputField;
    public float answer;
    private float userInput;

    public bool Validate() {
        if (!float.TryParse(valueInputField.text, out userInput)) {
            return false;
        }

        if (answer != userInput) {
            return false;
        }

        return true;
    }
}
