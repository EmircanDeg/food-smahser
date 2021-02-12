using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class presslemekod : MonoBehaviour
{
    public float hiz;
    float gerihiz;
    public bool ileri = true;
    public float xsinir;
    public bool sagmi = true;
    int say = 0;
    public int limit = 30;
    void Start()
    {
        gerihiz = hiz*1.5f;
    }
    public void gerisarma() { gameObject.transform.position = new Vector3(xsinir, transform.position.y, transform.position.z); }
    private void FixedUpdate()
    {
        if (sagmi == true) {
            if (transform.position.x > 2.5f) { if (ileri == true) { ilerigitme(); } }
            if(transform.position.x<=2.5f && transform.position.x > 1.8f) { hiz = hiz * 3;ilerigitme(); }
            if (transform.position.x < xsinir) { if (ileri == false) { gerigitme();say++; if (say > limit) { ileri = true; say = 0; } /*ileri = true; */} }
            if (transform.position.x >= xsinir) { ileri = true; say = 0;limit = 30; }
        }
        if (sagmi == false) {
            if (transform.position.x < -2.5f) { if (ileri == true) { ilerigitme(); } }
            if (transform.position.x >= -2.5f && transform.position.x < -1.8f) { hiz = hiz * 3; ilerigitme(); }
            if (transform.position.x > xsinir) { if (ileri == false) { gerigitme();say++;if (say > limit ){ ileri = true;say = 0; } /*/ileri = true;*/ } }
            if(transform.position.x <= xsinir) { ileri = true; say = 0; limit = 30; }
        }

        
    }
    void ilerigitme() { transform.position = transform.position + new Vector3(hiz,0,0); }
    public void gerigitme() { transform.position = transform.position + new Vector3(-gerihiz, 0, 0); }
}
