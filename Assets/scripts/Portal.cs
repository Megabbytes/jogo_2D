using UnityEngine;
using UnityEngine.SceneManagement;
public class Portal : MonoBehaviour
{
    private Rigidbody2D rb;// declara uma variável privada do tipo Rigidbody2D chamada "rb"

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();// pega o componente Rigidbody2D do objeto que possui este script anexado
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Portal"))// verifica se o objeto com o qual o jogador colidiu tem a tag "Portal"
        {
            SceneManager.LoadScene(2);// faz com que o jogo reinicie quando o jogador colidir com um objeto com a tag "Portal"
        }
        else if (collision.gameObject.CompareTag("Portal_2"))// verifica se o objeto com o qual o jogador colidiu tem a tag "Portal2"
        {
            SceneManager.LoadScene(0);// faz com que o jogo reinicie quando o jogador colidir com um objeto com a tag "Portal2"





        }
    }
}
