using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devametbutonscript : MonoBehaviour
{
    public GameObject buton;
    public GameObject ikincireklam;
    public GameObject sag;
    public GameObject oyunsonumenu;
    public bool bittimi = false;
    void Start()
    {
        
    }

    void oyunsonumenusu() { oyunsonumenu.SetActive(true); bittimi = true; }
    
    
    void Update()
    {
        if (ikincireklam.GetComponent<reklamci>().reklambitti == true) { Destroy(buton); }
        if (bittimi == false) { if (sag.transform.position.x < 2.6f) { Invoke("oyunsonumenusu", 1f); }; }
        
        
    }
}
