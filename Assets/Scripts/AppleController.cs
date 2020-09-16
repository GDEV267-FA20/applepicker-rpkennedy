using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleController : MonoBehaviour
{
    public static float bottom = -20f;

    void Start()
    {        
    }

    void Update()
    {
        if (transform.position.y < bottom)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision coll)
    {
        GameObject bonk = coll.gameObject;

        if(bonk.tag == ("Apple"))
        {
            Destroy(bonk);
        }
    }
}
