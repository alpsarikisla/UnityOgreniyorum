using UnityEngine;

public class GulleHareket : MonoBehaviour
{
    public Rigidbody Gulle;
    public int zKuvvet;
    public int yKuvvet;
    // Start is called before the first frame update
    void Start()
    {
        //Gulle.AddForce(0,yKuvvet,zKuvvet);
        Debug.Log("Merhaba Unity");
        //Gulle.AddForce(0, 0, 200);
    }

    // Update is called once per frame
    //void Update()
    //{
    //    //Gulle.AddForce(0, yKuvvet, zKuvvet);
    //    Gulle.AddForce(0, 0, 200);
    //}

    void FixedUpdate()
    {
        Gulle.AddForce(0, 0, 200);
    }
}
