using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    float degreeValue = 0;
    float magnitude = 14;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, Mathf.Cos(degreeValue * Mathf.Deg2Rad) * magnitude * Time.deltaTime, 0);

        degreeValue += 1;

        if (degreeValue >= 360)
        {
            degreeValue = 0;
        }
    }
}
