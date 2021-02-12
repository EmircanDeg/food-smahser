using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oldunskor : MonoBehaviour
{
    public GameObject skor;
    void Start()
    {
        
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text= skor.GetComponent<TextMesh>().text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
