using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject basket;
    public int numBasket;
    public float baseline;
    public float spacing;
    public List<GameObject> baskList;


    void Start()
    {
        baskList = new List<GameObject>();

        for(int i = 0; i < numBasket; i++)
        {
            GameObject bask = Instantiate<GameObject>(basket);
            Vector3 pos = Vector3.zero;
            pos.y = baseline + (spacing * i);
            basket.transform.position = pos;
            baskList.Add(bask);
        }
    }

    void Update()
    {
    }

    public void AppleDestroyed()
    {
        GameObject[] ladArray = GameObject.FindGameObjectsWithTag("Apple");

        foreach (GameObject lad in ladArray)
        {
            Destroy(lad);
        }                    //sorry lads

        int baskInd = baskList.Count - 1;
        GameObject bask = baskList[baskInd];
        baskList.RemoveAt(baskInd);
        Destroy(bask);

        if (baskList.Count == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }                        
}
