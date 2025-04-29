# 🎮 FecafGameUnity

Projeto de jogo 2D desenvolvido com Unit e C#

## 📌 Descrição

É um jogo em 2D com foco em [exploração / plataforma ], onde o jogador controla o personagem pulando em obstáculos. O objetivo do jogo é chegar até o fruto.

## 🛠️ Tecnologias utilizadas

- Unity 
- C#

## 🎮 Mecânicas principais

- Movimento em 2D (andar, pular, pegar)
- Detecção de fim de fase
- Sistema de menus (início, pausa, fim)
- [Outras mecânicas específicas do seu jogo]

  ## 📁 Script
  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    private float horizontalInput;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    public AudioSource somDoPulo;

    [SerializeField] private int velocidade = 5;
    [SerializeField] private Transform PeDoPersonagem;
    [SerializeField] private LayerMask ChaoLayer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao())
        {
            rb.AddForce(Vector2.up * 600);
            Pular(); // ← Toca o som ao pular
        }

        // Flip baseado na direção do movimento
        if (horizontalInput < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (horizontalInput > 0)
        {
            spriteRenderer.flipX = false;
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalInput * velocidade, rb.linearVelocity.y);
    }

    private bool estaNoChao()
    {
        return Physics2D.OverlapCircle(PeDoPersonagem.position, 0.2f, ChaoLayer);
    }

    public void Pular()
    {
        if (somDoPulo != null)
        {
            somDoPulo.Play();
        }
    }
}


