using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SkorHesapla : MonoBehaviour
{
    public Transform Oyuncu;
    public TextMeshProUGUI SkorMetin;

    // Update is called once per frame
    void Update()
    {
        SkorMetin.text = Oyuncu.position.z.ToString("0");
    }
}
