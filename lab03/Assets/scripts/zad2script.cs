using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2script : MonoBehaviour
{
    public float speed = 1.0f;

    void Start()
    {

    }

    void FixedUpdate()
    {
        Vector3 pos_temp = transform.position;
        if (pos_temp.x <= 0.001)
        {
            pos_temp.x = 0.01f;
        }
        Vector3 pos = pos_temp.normalized * speed * Time.deltaTime;
        transform.position += pos;
        if (transform.position.x >= 10 || transform.position.x <= 0)
        {
            speed *= -1;
        }
    }
}
