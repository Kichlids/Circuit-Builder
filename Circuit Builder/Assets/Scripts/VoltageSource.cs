using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VoltageSource : MonoBehaviour
{
    public RawImage image;

    public TMP_InputField voltageInput;

    private void Update() {
        print(Validate());
    }

    public bool Validate() {
        if (float.TryParse(voltageInput.text, out float volts)) {
            return true;
        }
        return false;
    }
}
