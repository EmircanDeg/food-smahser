using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombascript : MonoBehaviour
{
    public GameObject cizirti;
    public GameObject patlatici;
    public GameObject patlamaefekt;
    public bool patliyor = false;
    private Vector3 mouspozisyonu;
    private Vector3 pos;
    private Vector3 ilkPos;
    public AudioSource cistik;
    bool basma;
    public GameObject bombakontrol;
    public AudioSource patpat;
    float dist = 10;
    bool hareketli = true;
    Rigidbody rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouspozisyonu = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
            ilkPos = Camera.main.ScreenToWorldPoint(mouspozisyonu) - transform.position;
        }
        basma = true;
        hareketli = false;
    }
    private void OnMouseDrag()
    {
        mouspozisyonu = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
        pos = Camera.main.ScreenToWorldPoint(mouspozisyonu);
        if (basma)
            transform.position = new Vector3(pos.x - ilkPos.x, 5, pos.z - ilkPos.z); //pos - initialPos;
    }
    private void OnMouseUp()
    {
        basma = false;
    }
    void patlama() {if (PlayerPrefs.GetInt("titresimci")==0) { Handheld.Vibrate(); } ; patlatici.SetActive(true); patpat.Play(); Instantiate(patlamaefekt,new Vector3(transform.position.x,transform.position.y+2,transform.position.z),transform.rotation) ;
        gameObject.GetComponent<MeshRenderer>().enabled=false ; PlayerPrefs.SetInt("bombasayisi",PlayerPrefs.GetInt("bombasayisi")-1); bombakontrol.GetComponent<bombakontrol>().bombasummon();/*gameObject.GetComponent<SphereCollider>().enabled = false*/ }
    void Update()
    {
        if (transform.position.y > 4.5f) { if (patliyor == false) { cizirti.SetActive(true);cistik.Play(); Invoke("patlama", 3f); patliyor = true; }  }
        if (patlatici.transform.localScale.x >= 8) { Destroy(gameObject); }
        if (hareketli == true) { rb.AddForce(new Vector3(Random.Range(-20000, 20000), 0, Random.Range(-20000, 20000))); }
        if (transform.position.y < -10) { rb.velocity = Vector3.zero; }
    }
    private void OnTriggerEnter(Collider other)
    {
       
    }

    
}
