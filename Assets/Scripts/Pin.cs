using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public bool isKnockedDown = false;
    private Vector3 ogPos;


    private void Start()
    {
        ogPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator resetPin(float duration) 
    { 
        Vector3 startPos = transform.position;
        float currentTime = 0;

        while(currentTime < duration)
        {
            transform.position = Vector3.Lerp(startPos, ogPos, currentTime / duration);
            currentTime += Time.deltaTime;
            yield return null;
        }
        transform.position = ogPos;
        transform.rotation = Quaternion.identity;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        isKnockedDown = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball") || collision.gameObject.CompareTag("Pin"))
        {
            isKnockedDown = true;
        }
    }
}
