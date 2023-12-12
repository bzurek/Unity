using UnityEngine;

public class playerrespawn : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "floor")
        {
            playermanager.isGameOver = true;
            gameObject.SetActive(false);
        }
        else if(collision.transform.tag == "endgame")
        {
            playermanager.isEnd = true;
            gameObject.SetActive(false);
        }
    }
}
