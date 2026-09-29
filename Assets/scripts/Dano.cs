using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dano : MonoBehaviour
{
    private Rigidbody2D rb;// declara uma variável privada do tipo Rigidbody2D chamada "rb"

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();// pega o componente Rigidbody2D do objeto que possui este script anexado
    }

   
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dano"))// verifica se o objeto com o qual o jogador colidiu tem a tag "Dano"
        {
            SceneManager.LoadScene(0);// faz com que o jogo reinicie quando o jogador colidir com um objeto com a tag "Dano"
        }
    }
}
