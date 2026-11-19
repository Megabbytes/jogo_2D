using UnityEngine;
using UnityEngine.SceneManagement;

public class inimigo : MonoBehaviour
{
    public Transform player; // Referencia para o transform do player
    public float velocidade = 3f; // Velocidade de movimento do inimigo
    public MenuScene menu; // Referência para o script MenuScene

    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position,player.position,velocidade * Time.deltaTime);// faz o inimigo seguir o player
    }

    private void OnCollisionEnter2D(Collision2D collision)// Quando o inimigo colidir com outro objeto, essa função é chamada
    {
        if (collision.gameObject.CompareTag("Player"))// verifica se o objeto com o qual o inimigo colidiu tem a tag "Player"
        {
            menu.MostarGameOver();// chama a função MostarGameOver() do script MenuScene para exibir a tela de Game Over
        }
    }
}
