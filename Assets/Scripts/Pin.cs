using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public PinCount pinCounter;
    public Rigidbody pin;
    private bool isKnockedDown = false;

    // Start is called before the first frame update
    void Start()
    {
        pinCounter = FindObjectOfType<PinCount>();  
        pin = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isKnockedDown && (transform.rotation.x >= 0.2f || transform.rotation.z >= 0.2f))
        {
            isKnockedDown = true;
            pinCounter.PinKnockedDown();
        }
    }
}
