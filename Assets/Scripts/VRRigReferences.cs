using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRRigReferences : MonoBehaviour
{

    public static VRRigReferences Singleton;

    public Transform root;
    public Transform head;
    public MeshFilter headAesthetic;
    public Transform leftHand;
    public Transform rightHand;
    public GameObject[] modelsHat;

    private void Awake()
    {
        Singleton = this;
    }
}
