﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TiltEffect : MonoBehaviour {

    bool direction = true;
    public int maxTextSize;
    public int minTextSize;
    public TextMeshProUGUI m_Text;
	
	// Update is called once per frame
	void Update () {
        // Call the method to change the font size every update (frame)
        changeFontSize();
	}

    // Method which makes a text grow and shrink
    void changeFontSize()
    {
        // This switch controls if the text has to grow or shrink
        switch (direction)
        {
            case true:
                if (m_Text.fontSize < maxTextSize)
                {
                    m_Text.fontSize++;
                }
                else direction = false;
                break;
            case false:
                if (m_Text.fontSize > minTextSize)
                {
                    m_Text.fontSize--;
                }
                else direction = true;
                break;
            default:
                break;
        }
    }
}
