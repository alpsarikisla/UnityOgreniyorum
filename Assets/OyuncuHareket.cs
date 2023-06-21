using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class OyuncuHareket : MonoBehaviour
{
    public Rigidbody rb;

    public float ileriGuc = 2000f;
    // Update is called once per frame
    public float yonGuc = 500f;

    void Update()
    {
        rb.AddForce(0, 0, ileriGuc * Time.deltaTime);
        if (Input.GetKey("d"))//Eðer Klavyeden d butonuna basýlmýþsa
        {
            rb.AddForce(yonGuc * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-yonGuc * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
