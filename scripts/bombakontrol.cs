using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombakontrol : MonoBehaviour
{
    public GameObject bomba;
    public GameObject bombsayisi;
    void Start()
    {
        
        if(PlayerPrefs.GetInt("ilkbomba")!= 1) { PlayerPrefs.SetInt("bombasayisi", 3);PlayerPrefs.SetInt("ilkbomba", 1); }
        bombasummon();
    }

    public void bombasummon() { if (PlayerPrefs.GetInt("bombasayisi") > 0) { Instantiate(bomba, transform.position, transform.rotation); }  }
    void Update()
    {
        bombsayisi.GetComponent<TextMesh>().text = PlayerPrefs.GetInt("bombasayisi").ToString();
        
    }
}
