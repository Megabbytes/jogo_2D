using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dano : MonoBehaviour
{
    public MenuScene menu;// variavel usada para acessar o script do menu
    private void OnCollisionEnter2D(Collision2D collision)// Quando o inimigo colidir com outro objeto, essa função é chamada
    {
        if (collision.gameObject.CompareTag("Dano"))// verifica se o objeto com o qual o inimigo colidiu tem a tag "Dano"
        {
            menu.MostarGameOver();// chama a função MostarGameOver() do script MenuScene para exibir a tela de Game Over
        }
       
    }
}
