using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jump;
    private Rigidbody2D body;
    private bool grounded;
    private Animator anim;

    private void Awake()
    {
        //dodanie referencji do rigidbody
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //odwaracanie sprite gracza, w zależności w jakim kierunku się porusza
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(1.5f, 1.5f, 1);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-1.5f, 1.5f, 1);

        if (Input.GetKey(KeyCode.Space) && grounded)
            Jump();
        //ustawienia do animatora
        anim.SetBool("run", horizontalInput != 0);
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, jump);
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
            grounded = true;
    }
}