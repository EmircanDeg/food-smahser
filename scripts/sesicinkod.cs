using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sesicinkod : MonoBehaviour
{
    public GameObject music;
    public GameObject sounds;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("muzikk")==1){
            music.SetActive(false);
        }else if(PlayerPrefs.GetInt("muzikk")==0){
            music.SetActive(true);
        }

        if(PlayerPrefs.GetInt("soundd")==1){
            sounds.SetActive(false);
        }else if(PlayerPrefs.GetInt("soundd")==0){
            sounds.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
