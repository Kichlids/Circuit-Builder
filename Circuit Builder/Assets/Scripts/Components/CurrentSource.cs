using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentSource : Component {

    public RawImage image;

    private void Update() {
        print(Validate());
    }
}
