using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

            GameController gameScript = Camera.main.GetComponent<GameController>();
            gameScript.AppleDestroyed();                       
        }
    }    
}
