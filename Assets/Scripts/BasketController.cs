using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        Vector3 mousePosNew = Camera.main.ScreenToWorldPoint(mousePos);
        Vector3 pos = this.transform.position;
        pos.x = mousePosNew.x;
        this.transform.position = pos;
    }
}
