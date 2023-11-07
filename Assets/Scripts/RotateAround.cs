using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public GameObject axisOfRotation;
    float degreeValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.RotateAround(axisOfRotation.transform.position, Vector3.up, 3 * Time.deltaTime);

        transform.position += new Vector3(0, Mathf.Cos(degreeValue * Mathf.Deg2Rad) * 14 * Time.deltaTime, 0);

        degreeValue += 1;

        if(degreeValue >= 360)
        {
            degreeValue = 0;
        }
        
    }
}
