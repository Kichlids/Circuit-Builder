using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrentSource : MonoBehaviour {
    public RawImage image;

    public TMP_InputField ampInput;

    private void Update() {
        print(Validate());
    }

    public bool Validate() {
        if (float.TryParse(ampInput.text, out float amp)) {
            return true;
        }
        return false;
    }
}
