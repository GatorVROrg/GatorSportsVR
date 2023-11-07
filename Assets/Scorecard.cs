using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Scorecard : MonoBehaviour
{
    public GameObject[] rows = new GameObject[5];
    
    //create an array of TextMeshProUGUI elements called text_boxes with 99 elements
    public TextMeshProUGUI[] text_boxes = new TextMeshProUGUI[99];

    void Start()
    {
        // add all TextMeshProUGUI elements to the text_boxes array
        text_boxes = GetComponentsInChildren<TextMeshProUGUI>();
    }

    void Update()
    {

    }
}
