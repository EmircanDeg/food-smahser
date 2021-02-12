using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menukaymalari : MonoBehaviour
{
    public GameObject animeci;
    public GameObject setci;
    public GameObject sbutci;
    public GameObject akici;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void baslatma(){
        Animator animatorp = akici.GetComponent<Animator>();
        animatorp.SetBool("akici", true);
        StartCoroutine(bekleyis());
    }

    IEnumerator bekleyis(){
        yield return new WaitForSeconds(1.07f);
        SceneManager.LoadScene("SampleScene");
    }

    public void settingacma(){
        Animator animatork = setci.GetComponent<Animator>();
        animatork.SetBool("stkay", true);
        Animator animatorw = sbutci.GetComponent<Animator>();
        animatorw.SetBool("donme", true); 
    }

    public void settingkapama(){
        Animator animatork = setci.GetComponent<Animator>();
        animatork.SetBool("stkay", false);
        Animator animatorw = sbutci.GetComponent<Animator>();
        animatorw.SetBool("donme", false);
    }

    public void bombaacma(){
        Animator animator = animeci.GetComponent<Animator>();
        animator.SetBool("basic", true);
    }

    public void bombakapama(){
        Animator animator = animeci.GetComponent<Animator>();
        animator.SetBool("basic", false);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
