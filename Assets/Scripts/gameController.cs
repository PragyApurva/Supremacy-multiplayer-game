using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public static gameController instance;

    public Transform[] spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    
}
