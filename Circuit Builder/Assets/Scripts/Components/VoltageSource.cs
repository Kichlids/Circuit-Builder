using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoltageSource : Component {

    public RawImage image;

    private void Update() {
        print(Validate());
    }
}
