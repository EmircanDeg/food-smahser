using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombaalma : MonoBehaviour
{
    public GameObject reklamlar;
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        reklamlar.GetComponent<reklamlar>().ShowRewardedVideo();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
