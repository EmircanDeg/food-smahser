using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderlar : MonoBehaviour
{
    public Slider musica;
    public Slider sounda;
    public Slider vibra;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("muzikk")==1){
            musica.value=1;
        }else{
            musica.value=0;
        }

        if(PlayerPrefs.GetInt("soundd")==1){
            sounda.value=1;
        }else{
            sounda.value=0;
        }

        if(PlayerPrefs.GetInt("titresimci")==1){
            vibra.value=1;
        }else{
            vibra.value=0;
        }
    }

    public void musicSlideci(float value){
        if(value==1){
            PlayerPrefs.SetInt("muzikk",1);
        }else if(value==0){
            PlayerPrefs.SetInt("muzikk",0);
        }
        
    }

    public void soundSlideci(float value){
        if(value==1){
            PlayerPrefs.SetInt("soundd",1);
        }else if(value==0){
            PlayerPrefs.SetInt("soundd",0);
        }
        
    }

    public void vibrSlideci(float value){
        if(value==1){
            PlayerPrefs.SetInt("titresimci",1);
        }else if(value==0){
            PlayerPrefs.SetInt("titresimci",0);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
