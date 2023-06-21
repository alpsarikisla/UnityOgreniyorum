using UnityEngine;

public class OyuncuCollision : MonoBehaviour
{
    public OyuncuHareket hareket;
   
    void OnCollisionEnter(Collision TemasBilgisi)
    {
        if (TemasBilgisi.collider.tag == "Engel")
        {
            hareket.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
