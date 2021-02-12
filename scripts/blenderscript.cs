using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blenderscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<donme>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 4.5F) { gameObject.GetComponent<donme>().enabled = true;Destroy(gameObject, 8); }
    }
}
