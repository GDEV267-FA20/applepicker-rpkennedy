using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketController : MonoBehaviour
{
    public Text score;

    void Start()
    {
        GameObject scoreObj = GameObject.Find("ScoreCounter");
        score = scoreObj.GetComponent<Text>();
        score.text = "0";
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

    void OnCollisionEnter(Collision coll)
    {        
        if (coll.gameObject.tag == ("Apple"))
        {
            Destroy(coll.gameObject);


            int points = int.Parse(score.text);
            points += 100;
            score.text = points.ToString();
            if (points > HSController.score)
            {
                HSController.score = points;
            }
        }
    }
}
