using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CustomizationMenu : MonoBehaviour
{
    public TextMeshProUGUI sliderValueText;
    public Slider sliderHair;
    public Slider sliderHat;
    public Slider sliderColor;    
    public Mesh[] modelsHat;
    public Mesh[] modelsHair;

    public MeshFilter hairRenderer;
    public MeshFilter hatRenderer;
    public MeshFilter colorRenderer;
    private int currentIndex = 0;

    public void Start()
    {
        UpdateSliderValueText();
    }

    public void Update()
    {
        hairRenderer.mesh = modelsHair[(int)sliderHair.value];
        hatRenderer.mesh = modelsHat[(int)sliderHat.value];
        
    }

    private void SwitchModel(float index)
    {
        // Disable the current model's renderer
        hairRenderer.enabled = false;

        // Enable the renderer of the selected model
        currentRenderer = models[index].GetComponent<Renderer>();
        currentRenderer.enabled = true;

        // Update the slider value text
        UpdateSliderValueText();
    }

    private void UpdateSliderValueText()
    {
        sliderValueText.text = $"Model Index: {currentIndex}";
    }
}
