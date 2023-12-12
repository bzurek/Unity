using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    [SerializeField] private float movespeed = 0.75f;
    [SerializeField] private float yUp = 1.25f;
    [SerializeField] private float yDown = -0.9f;
    [SerializeField] private bool PlayerOn = false;
    public GameObject player;

    void Update()
    {
        if (transform.position.y >= yUp)
        {
            movespeed = -movespeed;
        }
        else if (transform.position.y <= yDown)
        {
            movespeed = Mathf.Abs(movespeed);
        }
        Vector3 move = transform.up * movespeed * Time.deltaTime;
        transform.Translate(move);
        if(PlayerOn)
        {
            player.transform.Translate(move);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            PlayerOn = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            PlayerOn = false;
        }
    }
}
