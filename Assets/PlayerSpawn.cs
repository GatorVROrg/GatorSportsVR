using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerSpawn : NetworkBehaviour
{
    public Transform spawnTransform;
    // Start is called before the first frame update

    public override void OnNetworkSpawn()
    {
        transform.position = spawnTransform.position;
    }
}
