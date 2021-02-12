using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homeretry : MonoBehaviour
{
    public bool evmi = true;
    public GameObject reklamlar;
    void Start()
    {
        
    }

    private void OnMouseDown(){
        if(evmi==true){
            reklamlar.GetComponent<reklamlar>().ShowInterstitialAd();
            SceneManager.LoadScene("anamenu");
        }else{
            reklamlar.GetComponent<reklamlar>().ShowInterstitialAd();
            SceneManager.LoadScene("SampleScene");
        }
    }
    public void homegit()
    {
        reklamlar.GetComponent<reklamlar>().ShowInterstitialAd();
        SceneManager.LoadScene("anamenu");
    }
    
    public void retri()
    {
        reklamlar.GetComponent<reklamlar>().ShowInterstitialAd();
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
