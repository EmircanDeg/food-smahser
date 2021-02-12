using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kombogosterim : MonoBehaviour
{
    public Sprite[] kombolar;
    GameObject kontrol;
    void Start()
    {
        kontrol = GameObject.Find("kontrol");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite=kombolar[kontrol.GetComponent<oyunkontrol>().kombo];
    }
}
