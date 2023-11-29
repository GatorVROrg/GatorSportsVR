using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CustomizationMenu : MonoBehaviour
{
    public Slider sliderHeadType;
    public Slider sliderHat;
    public Slider sliderColor;    
    public GameObject[] modelsHat;
    public Mesh[] modelHeads;
    public MeshFilter headRenderer;
    public GameObject[] colorRenderer = new GameObject[4];
    public Material[] colors;
    public void Update()
    {
        colorRenderer[1] = GameObject.Find("hands:Rhand");
        colorRenderer[2] = GameObject.Find("hands:Lhand");

        headRenderer.mesh = modelHeads[(int)sliderHeadType.value];
        if((int)sliderHat.value == 0)
        {
            foreach(var item in modelsHat)
            {
                item.SetActive(false);
            }
        }
        else
        {
            foreach(var item in modelsHat)
            {
                item.SetActive(false);
            }
            modelsHat[(int)sliderHat.value].SetActive(true);
        }

        foreach(var item in colorRenderer)
        {
            if(item.GetComponent<MeshRenderer>() == null)
            {
                item.GetComponent<SkinnedMeshRenderer>().material = colors[(int)sliderColor.value];
            }
            else
            {
                item.GetComponent<MeshRenderer>().material = colors[(int)sliderColor.value];
            }
        }
    }
}
