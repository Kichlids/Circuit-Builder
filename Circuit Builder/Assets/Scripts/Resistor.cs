using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Resistor : MonoBehaviour
{
    public RawImage image;

    public TMP_InputField ohmInput;

    private void Update() {
        print(Validate());
    }

    public bool Validate() {
        if (float.TryParse(ohmInput.text, out float ohm)) {
            return true;
        }
        return false;
    }



}
