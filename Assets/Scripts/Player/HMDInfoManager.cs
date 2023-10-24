using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{

    public GameObject DeviceSimulator;

    void Start()
    {
        Debug.Log("Is Device Active " + XRSettings.isDeviceActive);
        Debug.Log("Device Name is : " + XRSettings.loadedDeviceName);


        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No Headset plugged");
        }
        else if (XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "Mock HMD"
            || XRSettings.loadedDeviceName == "MockHMD Display"))
        {
            Debug.Log("Using Mock HMD");
            DeviceSimulator.SetActive(true);
        }
        else
        {
            Debug.Log("We have a headset " + XRSettings.loadedDeviceName);
            DeviceSimulator.SetActive(false);
        }
    }
}
