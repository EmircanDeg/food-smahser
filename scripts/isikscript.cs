using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isikscript : MonoBehaviour
{
    public  Material[] materyaller;
    GameObject oyunkontrol;
    bool rush = false;
    void Start()
    {
        //gameObject.GetComponent<MeshRenderer>().material = materyaller[0];
        oyunkontrol = GameObject.Find("kontorl");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rush);
        rush = oyunkontrol.GetComponent<oyunkontrol>().rushgeldimi;
        if (rush == true) { gameObject.GetComponent<MeshRenderer>().material = materyaller[1]; }
        if (rush == false) { gameObject.GetComponent<MeshRenderer>().material = materyaller[0]; }
    }
}
