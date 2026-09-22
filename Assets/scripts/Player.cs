using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f; // Variável pública do tipo float que define a velocidade de movimento do player. Essa velocidade será usada para calcular a velocidade horizontal do player com base na entrada do usuário. O valor inicial é 5, mas pode ser ajustado no Inspector do Unity para aumentar ou diminuir a velocidade de movimento.

    private Rigidbody2D rb; // Variável privada do tipo Rigidbody2D que será usada para armazenar o componente Rigidbody2D do player. O Rigidbody2D é responsável por aplicar física ao player, permitindo que ele se mova e interaja com o ambiente de forma realista.
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtém o componente Rigidbody2D do player e o armazena na variável rb para que possamos aplicar forças a ele posteriormente
    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");// reconhece o movimeto do player horizontalmente, seja para esquerda ou direita

        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y);// faz o calculo da movimentação do player, multiplicando a velocidade pelo movimento horizontal e mantendo a velocidade vertical atual do player
    }
}
