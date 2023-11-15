using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruchpunktowy : MonoBehaviour
{
    public List<Vector3> punkty;
    private Vector3 start;
    public float platspeed = 3.1f;
    private bool czyprzod = true;
    private bool czytyl = false;
    private bool czyruch = true;
    private bool czypunkt = false;
    private Vector3 direction;
    private Transform oldParent;


    void Start()
    {
        start = transform.position;
    }

//    void FixedUpdate()
//    {
//        if (isRunningForward && transform.position.x)  >= czypunkt.x )
//        {
//            czyruch = false;
//        }
//        else if (isRunningBackward && transform.position.x <= startPosition.x)
//        {
//            isRunning = false;
//        }

//        if (czyruch)
//        {

//            if (isRunningForward) direction = finalPosition;
//            else if (isRunningBackward) direction = -finalPosition;

//            Vector3 move = direction.normalized * platspeed * Time.deltaTime;
//            transform.Translate(move);
//        }
//    }

//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.gameObject.CompareTag("Player"))
//        {
//            Debug.Log("Player wszedł na windę.");
//            oldParent = other.gameObject.transform.parent;
//            Debug.Log(oldParent);
//            other.gameObject.transform.parent = transform;

//            if (transform.position.x >= finalPosition.x)
//            {
//                isRunningBackward = true;
//                isRunningForward = false;

//            }
//            else if (transform.position.x <= startPosition.x)
//            {
//                isRunningBackward = false;
//                isRunningForward = true;

//            }
//            isRunning = true;
//        }
//    }

//    private void OnTriggerExit(Collider other)
//    {
//        if (other.gameObject.CompareTag("Player"))
//        {
//            Debug.Log("Player zszedł z windy.");
//            other.gameObject.transform.parent = oldParent;
//        }
//    }
}