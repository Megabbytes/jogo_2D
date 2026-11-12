using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Fase1"); // Carrega a cena do jogo quando o botão "Start Game" é pressionado
    }
    public void QuitGame()
    {
        Application.Quit(); // Encerra o jogo quando o botão "Quit Game" é pressionado
    }
    public void VoltarMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
