using UnityEngine;

public class Pulo : MonoBehaviour
{
    public float jumpForce = 10f; // Variável pública do tipo float que define a força do pulo do player. 
    private Rigidbody2D rb; // Variável privada do tipo Rigidbody2D que será usada para armazenar o componente Rigidbody2D do player.
    private bool isGrounded = true;// Variável booleana que indica se o player está no chão ou não.

    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();// Obtém o componente Rigidbody2D do player e o armazena na variável rb para que possamos aplicar forças a ele posteriormente
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)// Se a tecla de espaço for pressionada e o player estiver no chão (isGrounded é verdadeiro)
        {
           rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);// Adiciona uma força para cima no Rigidbody2D do player, fazendo ele pular
            isGrounded = false;// quando o player pula, ele não está mais no chão, então isGrounded é falso
        }

    }
    void OnCollisionEnter2D(Collision2D collision) // Quando o player colide com outro objeto, essa função é chamada
    {
        if (collision.gameObject.CompareTag("Ground"))// Se o objeto com o qual o player colidiu tem a tag "Ground" (chão)
        {
            isGrounded = true;// Quando o player colide com o chão, ele está no chão, então isGrounded é verdadeiro
        }
    }
}
