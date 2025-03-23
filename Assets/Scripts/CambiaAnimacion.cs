using System;
using UnityEngine;

/**
Modifica los parámetros del animator del Personaje
Autor: Israel González Huerta
*/
public class CambiaAnimacion : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer spRenderer;
    private Animator animator;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        animator.SetFloat("velocity", MathF.Abs(rb.linearVelocityX));
        spRenderer.flipX = rb.linearVelocityX < 0;
        animator.SetBool("isGrounded", EstadoPersonaje.enPiso);
    }
}
