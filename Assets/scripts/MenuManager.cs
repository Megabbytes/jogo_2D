using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public void StartGame()// começa o jogo
    {
        SceneManager.LoadScene("Fase1"); // Carrega a cena do jogo quando o botão "Start Game" é pressionado
    }
    public void QuitGame()//Sai do jogo
    {
        Application.Quit(); // Encerra o jogo quando o botão "Quit Game" é pressionado
    }
    public void VoltarMenu()// volta para o menu principal
    {
        Time.timeScale = 1f;// ativa o tempo do jogo, deixando ele voltar a funcionar normalmente
        SceneManager.LoadScene(0);// carrega a cena do menu principal, que é a primeira cena do jogo (índice 0)
    }
}
