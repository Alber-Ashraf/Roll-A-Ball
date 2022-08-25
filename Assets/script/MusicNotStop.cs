using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNotStop : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject); 
    }
        
}
