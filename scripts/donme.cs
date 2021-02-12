using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donme : MonoBehaviour
{
    public float xhiz = 0.3f;
    public float yhiz = 0.3f;
    public float zhiz = 0.3f;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Rotate(xhiz, yhiz, zhiz);
    }
    void Update()
    {
       
    }
}
