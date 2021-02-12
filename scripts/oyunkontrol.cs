using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oyunkontrol : MonoBehaviour
{
    public GameObject animeci;
    public GameObject obje1;
    public GameObject obje2;
    public bool kontrolet = false;
    public int goster;
    float rushbitti = 0;
    
    public float kombosayac = 3;
    public int kombo = 0;
    public int skor = 0;
    GameObject firlatici;
    bool zamanayar = false;
    public GameObject presssag;
    public GameObject presssol;
    public AudioSource ses;
    float rushzamani = 0;
    public GameObject rush;
    public bool rushgeldimi = false;
    public GameObject rushisik;
    public Material[] materyaller;
    GameObject rushhalo;
    
    public GameObject skoryazici;
    
    //public AudioSource pop;
    void Start()
    {
        animeci = GameObject.Find("donmeceix");
        firlatici = GameObject.Find("firlatici");
        rushhalo = GameObject.Find("rushhalo");
        rushhalo.SetActive(false);
    }

    IEnumerator delayci(){
        yield return new WaitForSeconds(.3f);
        Animator animator = animeci.GetComponent<Animator>();
        animator.SetBool("sayac", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (skor > PlayerPrefs.GetInt("highskor")) { PlayerPrefs.SetInt("highskor", skor); }
        rushzamani = rushzamani + Time.deltaTime;
        kombosayac = kombosayac - Time.deltaTime;
        if (kombosayac <= 0) { kombosayac = 3;kombo = 0; 
            Animator animator = animeci.GetComponent<Animator>();
            animator.SetBool("sayac", false);
        }
        skoryazici.GetComponent<TextMesh>().text = skor.ToString();
        
        /*if (zamanayar == true) { if (skor > 0) { if (skor % 10 == 0) { firlatici.GetComponent<firlatma>().zaman = firlatici.GetComponent<firlatma>().zaman - 0.06f; zamanayar = false; } } }*/
        if (kombo > 9) { if (rushgeldimi == false) { if (rushzamani > 10) {  rushhalo.SetActive(true); presssag.GetComponent<presslemekod>().hiz = presssag.GetComponent<presslemekod>().hiz * 2.5f; presssol.GetComponent<presslemekod>().hiz = presssol.GetComponent<presslemekod>().hiz * 2.5f; rush.SetActive(true); rushgeldimi = true; rushisik.GetComponent<MeshRenderer>().material = materyaller[1]; } } }

        if (rushgeldimi == true) {rushbitti = rushbitti + Time.deltaTime; }
        if (rushbitti > 10) { if (rushgeldimi == true) { rushhalo.SetActive(false); presssag.GetComponent<presslemekod>().hiz = presssag.GetComponent<presslemekod>().hiz / 2.5f; presssol.GetComponent<presslemekod>().hiz = presssol.GetComponent<presslemekod>().hiz / 2.5f; rush.SetActive(false); rushzamani = 0; rushgeldimi = false; rushisik.GetComponent<MeshRenderer>().material = materyaller[0];rushbitti = 0; } }
        if (skor > 0)
        {
            if (skor % 10 == 9) { zamanayar = true; }
        }


        if (kontrolet == true)
        {
                if (obje1.GetComponent<firlama>().eslesme == obje2.GetComponent<firlama>().eslesme) {
                    
                    
                    obje1.GetComponent<firlama>().fiskirtma(); obje2.GetComponent<firlama>().fiskirtma(); Destroy(obje1); Destroy(obje2); ses.Play(); obje1 = null; obje2 = null; kontrolet = false;presssag.GetComponent<presslemekod>().ileri = false; presssol.GetComponent<presslemekod>().ileri = false;kombosayac = 3;if (kombo < 10) {
                    kombo = kombo + 1;
                    
                    /*Animator animator = animeci.GetComponent<Animator>();
                    animator.SetBool("sayac", true);
                    StartCoroutine(delayci());*/}
                    Animator animator = animeci.GetComponent<Animator>();
                    animator.SetBool("sayac", true);
                    StartCoroutine(delayci());

                if (kombo < 1) { skor = skor + 10; } else { skor = skor + 10 * kombo; }

                }
                if (obje1.GetComponent<firlama>().eslesme != obje2.GetComponent<firlama>().eslesme) { obje1 = obje2; obje2 = null; kontrolet = false; }
        }
            goster = obje1.GetComponent<firlama>().eslesme;
        }
 }

