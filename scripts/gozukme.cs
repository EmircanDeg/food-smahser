using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gozukme : MonoBehaviour
{
    public int sec;
    public GameObject kontrol;
    void Start()
    {
        kontrol = GameObject.Find("kontrol");
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if(kontrol.GetComponent<oyunkontrol>().obje1!= null) { if (sec == kontrol.GetComponent<oyunkontrol>().goster) { gameObject.GetComponent<MeshRenderer>().enabled = false; gameObject.GetComponent<MeshRenderer>().enabled = true; } }
        if (kontrol.GetComponent<oyunkontrol>().obje1 != null) { if (sec != kontrol.GetComponent<oyunkontrol>().goster) { gameObject.GetComponent<MeshRenderer>().enabled = false;} }

        if (kontrol.GetComponent<oyunkontrol>().obje1 == null) { gameObject.GetComponent<MeshRenderer>().enabled = false; }
    }
}
