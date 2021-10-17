using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class skorScript : MonoBehaviour
{
    private TextMeshProUGUI skortext;    
    public static int skor = 0;
    void Start()
    {
        skortext = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        skortext.text = skor.ToString();
    }
}
