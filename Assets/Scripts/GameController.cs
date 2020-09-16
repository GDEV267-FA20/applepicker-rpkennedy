using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject basket;
    public int numBasket;
    public float baseline;
    public float spacing;

    void Start()
    {
        for(int i = 0; i < numBasket; i++)
        {
            GameObject bask = Instantiate<GameObject>(basket);
            Vector3 pos = Vector3.zero;
            pos.y = baseline + (spacing * i);
            basket.transform.position = pos;
        }
    }

    void Update()
    {

    }
}
