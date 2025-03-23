using System;
using UnityEngine;

public class MuevePersonaje : MonoBehaviour
{
    public float velocidadX;

    [SerializeField]
    private float velocidadY;
    private Rigidbody2D rb;

    /*public bool isGrounded = false;*/

    public CapsuleCollider2D capsule;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");

        bool movVertical = Input.GetKey(KeyCode.W);

        if(movVertical && EstadoPersonaje.enPiso)
        {
            rb.linearVelocityY = velocidadY;
        }

        rb.linearVelocity = new Vector2(movHorizontal * velocidadX, rb.linearVelocityY);
    }

    /*
    void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }
    */

}
