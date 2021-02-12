using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yemeksinir : MonoBehaviour
{
    GameObject xsinir1;
    GameObject xsinir2;
    void Start()
    {
        xsinir1 = GameObject.Find("sagsinir");
        xsinir2 = GameObject.Find("solsinir");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x< xsinir2.transform.position.x) { transform.position = new Vector3(xsinir2.transform.position.x + 0.8f, transform.position.y, transform.position.z); }
        if(transform.position.x > xsinir1.transform.position.x) { transform.position = new Vector3(xsinir1.transform.position.x - 0.8f, transform.position.y, transform.position.z); }
        if (transform.position.z < -14) { { transform.position = new Vector3(transform.position.x, transform.position.y, -14); } }
    }
}
