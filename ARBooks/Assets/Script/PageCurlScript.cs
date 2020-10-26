﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Linq;
using UnityEngine.EventSystems;

public class PageCurlScript : MonoBehaviour {
    // Start is called before the first frame update
    bool NextCurl = false;
    bool BackCurl = true;

    GameObject modeButton;
    ModeButtonScript script;
    bool mode;

    void Start() {
        modeButton = GameObject.Find("Canvas/ModeButton");
        script = modeButton.GetComponent<ModeButtonScript>();
    }

    public void SwitchPageCurl() {
        mode = script.getMode();
        if ((this.transform.eulerAngles.z <= 0.5f || Mathf.Abs(this.transform.eulerAngles.z)  >= 170) && !mode) {
            NextCurl = !NextCurl;
            BackCurl = !BackCurl;
        }
    }

    void Update() {
        if (this.transform.eulerAngles.z < 180 && NextCurl) {
            this.transform.Rotate(0, 0, 1.5f, Space.World );
        } else if (this.transform.eulerAngles.z  > 0.5 && BackCurl) {
            this.transform.Rotate (0, 0, -1.5f, Space.World );
        }
    }
}
