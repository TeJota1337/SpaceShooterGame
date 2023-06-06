using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int pontosDano = 5; // Quantidade de pontos de dano a serem subtraídos

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collide!");
            // Verifica se a colisão ocorreu com um objeto marcado com a tag "inimigos"
            PlayerMove player = collision.rigidbody.gameObject.GetComponent<PlayerMove>();


            if (player != null)
            {
                Debug.Log("Causou dano!");
                player.DiminuirVida(pontosDano);

            }
        }
    }
}
    