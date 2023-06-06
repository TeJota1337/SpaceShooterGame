using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class PlayerMove : MonoBehaviour
{
    public float speed = 5f; // velocidade do player
    public Camera mainCam;
    public Camera gameCam;

    public int vidaInicial = 100; // Vida inicial do jogador
    private int vidaAtual; // Vida atual do jogador

    private Rigidbody rigid;



    private void Start()
    {
        rigid = GetComponent<Rigidbody>();

        vidaAtual = vidaInicial; // Inicializa a vida atual com o valor inicial
    }

    private void Update()
    {
       
        // pega a posição do mouse em relação à camera PRINCIPAL (a que renderiza pro monitor, onde o mouse pertence)
        // X é a pos horizontal, Y a vertical e Z a distância da câmera
        // https://docs.unity3d.com/ScriptReference/Camera.ScreenToViewportPoint.html
        Vector3 mousePosViewport = mainCam.ScreenToViewportPoint(Input.mousePosition);
        // como o que importa é mover o personagem só em X e Z,
        // transferimos o valor de Y(vertical) para Z e zeramos o Y
        // (caso contrário o personagem vai rotacionar para cima/baixo também)
        mousePosViewport.Set(mousePosViewport.x, 0f, mousePosViewport.y);

        // pega a posição do player em relação à camera do GAME (a que renderiza pra textura, onde a cena pertence)
        Vector3 playerPosViewport = gameCam.WorldToViewportPoint(this.transform.position);
        // repetimos a mesma operação acima pelas mesmas razões
        playerPosViewport.Set(playerPosViewport.x, 0f, playerPosViewport.y);

        // para testes, pode remover quando não for mais relevante
        //Debug.Log("Mouse: " + mousePosViewport + " / Player: " + playerPosViewport);

        // aplica a rotação de fato, utilizando apenas a direção entre os dois vetores resultantes
        this.transform.forward = (mousePosViewport - playerPosViewport).normalized;
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // entrada do teclado para o movimento horizontal
        float moveVertical = Input.GetAxis("Vertical"); // entrada do teclado para o movimento vertical

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical); // cria um vetor de movimento

        rigid.AddForce(movement * speed); // aplica força ao rigidbody para mover o player

        if (transform.position.y >= 25)
        {
            Vector3 newPosition = transform.position;
            newPosition.y = 25;
            transform.position = newPosition;
        }
    }

    public void DiminuirVida(int pontos)
    {
        vidaAtual -= pontos;
        FindObjectOfType<HudScript>().UpdateLife(vidaAtual);

        if (vidaAtual <= 0)
        {
            // Verifica se a vida do jogador chegou a zero ou menos
            // Implemente aqui a lógica para quando o jogador morrer
        }
    }
}
