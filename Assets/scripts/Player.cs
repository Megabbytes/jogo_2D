using System.Runtime.CompilerServices;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moedas = 0f; // Variável pública do tipo float que armazena a quantidade de moedas coletadas
    public float speed = 5f; // Variável pública do tipo float que define a velocidade de movimento do player. 
    private Rigidbody2D rb; // Variável privada do tipo Rigidbody2D que será usada para armazenar o componente Rigidbody2D do player.
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtém o componente Rigidbody2D do player e o armazena na variável rb para que possamos aplicar forças a ele posteriormente
    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");// reconhece o movimeto do player horizontalmente, seja para esquerda ou direita

        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y);// faz o calculo da movimentação do player, multiplicando a velocidade pelo movimento horizontal e mantendo a velocidade vertical atual do player
    }

    private void OnTriggerEnter2D(Collider2D collision)// Quando o player colide com outro objeto, essa função é chamada
    {
        if (collision.gameObject.CompareTag("Moeda"))// Se o objeto com o qual o player colidiu tem a tag "Moeda"
        {
            moedas++;// Incrementa a quantidade de moedas coletadas em 1
            print("Moedas totais: " + moedas);// Imprime a quantidade total de moedas coletadas no console
        }
    }
 
}
