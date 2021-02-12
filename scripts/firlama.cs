using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firlama : MonoBehaviour
{
    Rigidbody rb;
    public float guc;
    public int eslesme;
    GameObject kontol;
    public GameObject presssag;
    public GameObject presssol;
    public bool esasmeyvemi = false;
    float sayac = 0;
    public GameObject fiskirmapatickle;
    
    void Start()
    {
        
        kontol = GameObject.Find("kontrol");
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, 0, -1)*guc);
        if (transform.position.y < -100f) { esasmeyvemi = true; }
        else { esasmeyvemi = false; }
        
    }

    
    void Update()
    {
        if (transform.position.y < -50) { rb.velocity = Vector3.zero; }
        if (transform.position.y > 2f) { transform.position = new Vector3(transform.position.x, 2, transform.position.z); }
        sayac = sayac + Time.deltaTime;
        if (transform.position.z > 1) { if (sayac > 3) { rb.AddForce(new Vector3(0, 0, -1000));sayac = 0; } }
        if (transform.position.z < 9) { sayac = 0; }
        if (presssag.transform.position.x < 2.55f) { fiskirtma();if(esasmeyvemi==false){ Destroy(gameObject); }  }
    }
    private void OnMouseDown()
    {
        rb.velocity = Vector3.zero;
        //rb.AddForce(Random.Range(-200,200), Random.Range(0, 100), Random.Range(-200, 200));
        if (kontol.GetComponent<oyunkontrol>().obje1 == null) {  kontol.GetComponent<oyunkontrol>().obje1 = gameObject;  }
        else if (kontol.GetComponent<oyunkontrol>().obje2 == null) { if (Object.ReferenceEquals(gameObject, kontol.GetComponent<oyunkontrol>().obje1) == false) { kontol.GetComponent<oyunkontrol>().obje2 = gameObject; kontol.GetComponent<oyunkontrol>().kontrolet = true;  } }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bomba") {kontol.GetComponent<oyunkontrol>().skor= kontol.GetComponent<oyunkontrol>().skor+5;fiskirtma(); presssag.GetComponent<presslemekod>().ileri = false; presssag.GetComponent<presslemekod>().limit = presssag.GetComponent<presslemekod>().limit + 8; presssol.GetComponent<presslemekod>().ileri = false; presssol.GetComponent<presslemekod>().limit= presssol.GetComponent<presslemekod>().limit+8; Destroy(gameObject); }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bomba") { kontol.GetComponent<oyunkontrol>().skor = kontol.GetComponent<oyunkontrol>().skor + 1; fiskirtma();presssag.GetComponent<presslemekod>().ileri=false; presssol.GetComponent<presslemekod>().ileri = false; Destroy(gameObject); }
    }

    public void fiskirtma() { Instantiate(fiskirmapatickle, transform.position, transform.rotation); }
}
