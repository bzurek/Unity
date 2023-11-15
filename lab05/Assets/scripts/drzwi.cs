using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drzwi : MonoBehaviour
{
    public GameObject door;
    public float distance = 10.1f;
    public Vector3 start;
    public Vector3 final;
    private float doorSpeed = 4f;
    private bool isRunning = false;
    private bool isRunningOpen = false;
    private bool isRunningClose = true;


    void Start()
    {
        start = door.transform.position;
        final = new Vector3 (door.transform.position.x + distance, door.transform.position.y, door.transform.position.z);
    }

    void Update()
    {
        if (isRunningOpen && door.transform.position.x >= final.x)
        {
            isRunning = false;
        }
        else if (isRunningClose && door.transform.position.x <= start.x)
        {
            isRunning = false;
        }

        if (isRunning)
        {
            Vector3 move = door.transform.right * doorSpeed * Time.deltaTime;
            door.transform.Translate(move);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (door.transform.position.x <= start.x)
            {
                isRunningOpen = true;
                isRunningClose = false;
                doorSpeed = Mathf.Abs(doorSpeed);
            }
            isRunning = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player zszedł z windy.");
            if (door.transform.position.x >= final.x)
            {
                isRunningOpen = false;
                isRunningClose = true;
                doorSpeed = -doorSpeed;
            }
            isRunning = true;
        }
    }
}
