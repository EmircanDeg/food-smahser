using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombaalanikod : MonoBehaviour
{
    public AudioSource pop;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "yemek") { pop.Play(); }
    }
    void Update()
    {
        if (gameObject.transform.localScale.x < 8) { gameObject.transform.localScale = gameObject.transform.localScale + new Vector3(0.3f, 0.3f, 0.3f); }
        
    }
}
