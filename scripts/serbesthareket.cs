using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serbesthareket : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 mouspozisyonu;
    private Vector3 pos;
    private Vector3 ilkPos;
    bool basma;
    float dist = 10;
    
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouspozisyonu = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
            ilkPos = Camera.main.ScreenToWorldPoint(mouspozisyonu) - transform.position;
        }
        basma = true;
    }
    private void OnMouseDrag()
    {
        mouspozisyonu = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
        pos = Camera.main.ScreenToWorldPoint(mouspozisyonu);
        if (basma)
            transform.position = new Vector3(pos.x - ilkPos.x, 2, pos.z-ilkPos.z); //pos - initialPos;
    }
    private void OnMouseUp()
    {
        basma = false;
    }
}
