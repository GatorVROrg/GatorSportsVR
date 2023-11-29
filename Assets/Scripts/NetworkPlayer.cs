using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class NetworkPlayer : NetworkBehaviour
{

    public Transform root;
    public Transform head;
    public MeshFilter headAesthetic;
    public Transform leftHand;
    public Transform rightHand;
    public GameObject[] modelsHat;

    public Renderer[] meshToDisable;

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        if (IsOwner)
        {
            foreach (Renderer r in meshToDisable)
            {
                r.enabled = false;
            }
        }
    }

    void Update()
    {
        if (IsOwner)
        {
            root.position = VRRigReferences.Singleton.root.position;
            root.rotation = VRRigReferences.Singleton.root.rotation;

            head.position = VRRigReferences.Singleton.head.position;
            head.rotation = VRRigReferences.Singleton.head.rotation;

            leftHand.position = VRRigReferences.Singleton.leftHand.position;
            leftHand.rotation = VRRigReferences.Singleton.leftHand.rotation;

            rightHand.position = VRRigReferences.Singleton.rightHand.position;
            rightHand.rotation = VRRigReferences.Singleton.rightHand.rotation;

            for(int i = 0; i < modelsHat.Length; i++)
            {
                if(VRRigReferences.Singleton.modelsHat[i].activeSelf)
                {
                    modelsHat[i].SetActive(true);
                }
                else
                {
                    modelsHat[i].SetActive(false);
                }
            }

            headAesthetic.mesh = VRRigReferences.Singleton.headAesthetic.mesh;
        }
    }
}
