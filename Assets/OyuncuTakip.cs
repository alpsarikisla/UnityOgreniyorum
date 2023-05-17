using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class OyuncuTakip : MonoBehaviour
{
    public Transform oyuncu;
    public Vector3 bosluk;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position = oyuncu.position + bosluk;
    }
}
