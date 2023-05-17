using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class OyuncuHareket : MonoBehaviour
{
    public Rigidbody rb;

    public float ileriGuc = 500f;
    public float ziplamaGuc = 500f;
    // Update is called once per frame
    public float yonGuc = 500f;

    void Update()
    {
        //AddForce(x, y, z);
        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, ileriGuc * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -ileriGuc * Time.deltaTime);
        }

        if (Input.GetKey("d"))//Eðer Klavyeden d butonuna basýlmýþsa
        {
            rb.AddForce(yonGuc * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-yonGuc * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, ziplamaGuc * Time.deltaTime, 0);
        }
    }
}
