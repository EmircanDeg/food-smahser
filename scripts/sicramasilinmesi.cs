using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sicramasilinmesi : MonoBehaviour
{
    bool cikti = false;
    void Start()
    {
        Invoke("ciktitrue", 1);
    }

    void ciktitrue() { cikti = true;silici(); }
    void silici() { Destroy(gameObject, 1.5f); }
    void Update()
    {
        
        
    }
    private void FixedUpdate()
    {
        if (cikti == true) { gameObject.GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, 2) * Time.deltaTime; }
    }
}
