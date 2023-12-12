using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float aheadDistance;
    public float cameraSpeed;
    private float lookAhead;

    private void Update()
    {
        //Follow player
        transform.position = new Vector3(player.position.x + lookAhead, transform.position.y, transform.position.z);
        lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * player.localScale.x), Time.deltaTime * cameraSpeed);
        if(transform.position.x<= -1.25f)
        {
            transform.position = new Vector3(-1.25f, transform.position.y, transform.position.z);
        }
        if(transform.position.x >= 16.95f)
        {
            transform.position = new Vector3(16.95f, transform.position.y, transform.position.z);
        }
    }
}