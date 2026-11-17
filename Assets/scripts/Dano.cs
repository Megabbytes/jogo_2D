using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dano : MonoBehaviour
{
    public MenuScene menu;
   
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dano"))
        {
            menu.MostarGameOver();
            // Se encostar no player
            if (collision.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    public Transform player;
    public float velocidade = 3f;

    void Update()
    {
        // Segue o player
        transform.position = Vector2.MoveTowards(
            transform.position,
            player.position,
            velocidade * Time.deltaTime
        );
    }
}
