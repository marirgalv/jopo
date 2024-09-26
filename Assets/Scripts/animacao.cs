using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonagem : MonoBehaviour
{
    public float velocidade = 5f;
    private Rigidbody2D rb;
    private Animator anim;

    void Start()
    {
        // Pega o Rigidbody2D e o Animator do personagem
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Movimentação básica
        float movimento = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movimento * velocidade, rb.velocity.y);

        // Definir o parâmetro "Speed" com base no valor absoluto da velocidade
        anim.SetFloat("Speed", Mathf.Abs(movimento));
    }
}
