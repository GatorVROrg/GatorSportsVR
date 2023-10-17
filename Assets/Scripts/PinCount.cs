using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PinCount : MonoBehaviour
{
    public TextMeshProUGUI pinCount;
    public int startingPins = 10;
    private int pinsKnocked = 0;

    // Start is called before the first frame update
    void Start()
    {
        pinsKnocked = 0;
        UpdatePinCountText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PinKnockedDown()
    {
        pinsKnocked++;
        UpdatePinCountText();
    }

    void UpdatePinCountText()
    {
        pinCount.text = pinsKnocked + " out of 10";
    }
}
