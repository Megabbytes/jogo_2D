using UnityEngine;
using UnityEngine.SceneManagement;

public class inimigo : MonoBehaviour
{
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Se encostar no player
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
        }
    }
}
