using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public Transform spawnTransform;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = spawnTransform.position;   
    }
}
