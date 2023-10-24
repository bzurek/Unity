using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad3script : MonoBehaviour
{
    public float speed = 1.0f;
    public int dir = 0;

    void Start()
    {

    }

    void FixedUpdate()
    {
        Vector3 direction = new Vector3();
        switch (dir)
        {
            case 0:
                direction = Vector3.right;
                break;
            case 1:
                direction = Vector3.forward;
                break;
            case 2:
                direction = Vector3.left;
                break;
            case 3:
                direction = Vector3.back;
                break;
        }
        Vector3 pos = direction * speed * Time.deltaTime;
        transform.position += pos;
        if (transform.position.x >= 10 && dir == 0)
        {
            dir = 1;
            transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        }
        if (transform.position.z >= 10 && dir == 1)
        {
            dir = 2;
            transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        }
        if (transform.position.x <= 0 && dir == 2)
        {
            dir = 3;
            transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        }
        if (transform.position.z <= 0 && dir == 3)
        {
            dir = 0;
            transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        }
    }
}