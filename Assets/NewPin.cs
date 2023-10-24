using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject parentPin;
    private Vector3[] orgPos;

    private void Start()
    {
        int index = 0;
        foreach (Transform t in transform.GetComponentsInChildren<Transform>()) 
        {
            orgPos[index] = t.position;
            index++;
        }
    }

    public void Reset()
    {
        int index = 0;
        foreach(Transform t in transform.GetComponentsInChildren<Transform>())
        {
            t.position = orgPos[index];
            t.rotation = Quaternion.identity;
            index++;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
