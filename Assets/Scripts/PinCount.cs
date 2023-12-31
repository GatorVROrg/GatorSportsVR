using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.XR.CoreUtils;

public class PinCount : MonoBehaviour
{
    public TextMeshProUGUI pinCount;
    public int score = 0;  // DEBUG ONLY, RESET TO PRIVATE
    public int pinsKnocked = 0;  // DEBUG ONLY, RESET TO PRIVATE
    private Pin[] pins;
    public float resetTime = 1.0f;
    public bool test = false;

    // Start is called before the first frame update
    void Start()
    {
        pinsKnocked = 0;
        pins = GetComponentsInChildren<Pin>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePinCountText();
        if (test)
        {
            Reset();
            test = false;
        }
    }

    void UpdatePinCountText()
    {
        pinsKnocked = 0;
        foreach (Pin p in pins)
        {
            if(p.isKnockedDown) 
            {
                pinsKnocked++;
            }
        }
    }

    public void Reset()
    {
        score += pinsKnocked;
        // iterate through all the pins in the pins list
        foreach (Pin pin in pins)
        {
            // reset the position and rotation of the pin
            StartCoroutine(pin.resetPin(resetTime));
        }
        pinsKnocked = 0;
    }
}
