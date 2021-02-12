using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rushefektor : MonoBehaviour
{
    
    public GameObject kontrol;
    public GameObject efekt;
    public bool yargici = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(yargici == true) {
            if (kontrol.GetComponent<oyunkontrol>().rushgeldimi == true)
            {
                for (int i = 0; i < 20; i++) { transform.position = new Vector3(Random.Range(-8.5f, 8.5f), transform.position.y, Random.Range(-11, 11)); Instantiate(efekt, transform.position, transform.rotation); }
                yargici = false;
            }
        }
        if(kontrol.GetComponent<oyunkontrol>().rushgeldimi == false) { yargici = true; }
        
    }
}
