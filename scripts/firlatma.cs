using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firlatma : MonoBehaviour
{
    public GameObject[] firlayanlar;
    public float zaman;
    public float sayac = 0;
    float ilk;
    float son;
    int secici;
    GameObject sagsinir;
    GameObject solsinir;
    public bool anamenumu = false;

    
    void Start()
    {
        if (anamenumu == false) { Invoke("cokluatma", 1.2f); }
        
        sagsinir = GameObject.Find("sagsinir");
        solsinir = GameObject.Find("solsinir");
            
    }

    // Update is called once per frame
    void Update()
    {
        ilk = solsinir.transform.position.x+0.8f;
        son = sagsinir.transform.position.x-0.8f;
        secici = Random.Range(0, firlayanlar.Length);
        sayac = sayac + Time.deltaTime;
        if (sayac > zaman)
        {
            Instantiate(firlayanlar[secici], transform.position, transform.rotation);
            transform.position = new Vector3(Random.Range(son, ilk), transform.position.y, transform.position.z);
            
            sayac = 0;

        }
    }
    void atma() { secici = Random.Range(0, firlayanlar.Length); Instantiate(firlayanlar[secici], transform.position, transform.rotation);
        transform.position = new Vector3(Random.Range(son, ilk), transform.position.y, transform.position.z);
    }
    void cokluatma() { Invoke("atma", 0.0f); Invoke("atma", 0.1f); Invoke("atma", 0.15f); Invoke("atma", 0.2f); Invoke("atma", 0.25f); Invoke("atma", 0.3f); Invoke("atma", 0.35f); Invoke("atma", 0.4f); Invoke("atma", 0.45f); Invoke("atma", 0.5f);
        Invoke("atma", 0.55f); Invoke("atma", 0.6f); Invoke("atma", 0.65f); Invoke("atma", 0.7f); Invoke("atma", 0.75f); Invoke("atma", 0.8f); Invoke("atma", 0.85f); Invoke("atma", 0.9f); Invoke("atma", 0.95f); Invoke("atma", 1f); }
}
    