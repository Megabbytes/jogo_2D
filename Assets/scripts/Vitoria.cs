using UnityEngine;
using UnityEngine.SceneManagement;

public class Vitoria : MonoBehaviour
{
    public GameObject telaVitoria;

    void Start()
    {
        telaVitoria.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.CompareTag("Player"))
        {
            telaVitoria.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void ReiniciarJogo()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
