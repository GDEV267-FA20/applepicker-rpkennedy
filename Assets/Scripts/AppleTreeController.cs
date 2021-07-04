using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTreeController : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject apple;
    public float speed;
    public float leftNright;
    public float chance;
    public float spawnTime;

    void Start()
    {
        Invoke("DropApple", spawnTime);
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftNright)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftNright)
        {
            speed = -Mathf.Abs(speed);
        }
    }

    void FixedUpdate()
    {
        if (Random.value < chance)
        {
            speed *= -1;
        }
    }

    void DropApple()
    {
        GameObject app = Instantiate<GameObject>(apple);
        app.transform.position = transform.position;
        Invoke("DropApple", spawnTime);
    }
}
