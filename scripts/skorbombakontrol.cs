using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameAnalyticsSDK;

public class skorbombakontrol : MonoBehaviour
{
    public Text highskor;
    public Text bombasayisi;
    void Start()
    {
        GameAnalytics.Initialize();
        highskor.text = PlayerPrefs.GetInt("highskor").ToString();
        bombasayisi.text = PlayerPrefs.GetInt("bombasayisi").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
