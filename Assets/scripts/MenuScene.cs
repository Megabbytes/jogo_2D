using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScene : MonoBehaviour
{
    public GameObject painelPause;// variavel que represo painel de pause, que é ativado e desativado quando o jogador aperta a tecla "ESC"
    public GameObject painelGameOver;// variavel que represo painel de game over, que é ativado quando o jogador perde todas as vidas

    bool Pausado = false;// variavel booleana que indica se o jogo está pausado ou não, inicia com false, pois o jogo inicia sem estar pausado
    bool jogoAcabou = false;// variale booleana que indica se o jogo acabou ou não, inicia com false, pois o jogo inicia sem ter acabado
    void Start()
    {
        painelPause.SetActive(false);// desativa o painel de pause no inicio do jogo, para que ele não apareça na tela
        painelGameOver.SetActive(false);//desativa o painel de game over no inicio do jogo, para que ele não apareça na tela
    }
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape))// verifica se o jogador apertou a tecla "ESC" para pausar ou continuar o jogo
        {
            if(Pausado)// verifica se o jogo está pausado
            {
                Continuar();// chama a função Continuar() para despausar o jogo
            }
            else
            {
                Pausar();// chama a função Pausar() para pausar o jogo
            }
      }
    }
    public void Pausar()// função que pausa o jogo, ativando o painel de pause e desativando o tempo do jogo
    {
        if(jogoAcabou == false)// verifica se o jogo acabou, para que o jogador não possa pausar o jogo quando ele já acabou
        {
            Pausado = true;// altera a variavel Pausado para true, indicando que o jogo está pausado
            painelPause.SetActive(true);// ativa o painel no jogo
            Time.timeScale = 0f;// deixa o jogo parado
        }
    }
    public void Continuar()// função que despausa o jogo, desativando o painel de pause e ativando o tempo do jogo
    {
        Pausado = false;// declara que o jogo não está mais pausado
        painelPause.SetActive(false);// desativa o painel de pause
        Time.timeScale = 1f;// ativa o tempo do jogo, deixando ele voltar a funcionar normalmente
    }
    public void MostarGameOver()// função que mostra o painel de game over, ativando o painel de game over e desativando o tempo do jogo
    {
        jogoAcabou = true;// declara que o jogo acabou, para que o jogador não possa pausar o jogo quando ele já acabou
        painelGameOver.SetActive(true);// ativa o painel de game over
        Time.timeScale = 0f;// deixa o jogo parado, para que o jogador não possa continuar jogando depois de perder todas as vidas

    }
    public void Reiniciar()// função que reinicia o jogo, carregando a cena atual novamente e ativando o tempo do jogo
    {
        Time.timeScale = 1f;// ativa o tempo do jogo, deixando ele voltar a funcionar normalmente
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);// carrega a cena atual novamente, reiniciando o jogo
    }

    public void VoltarMenu()// função que volta para o menu principal, carregando a cena do menu e ativando o tempo do jogo
    {
        Time.timeScale = 1f;// ativa o tempo do jogo, deixando ele voltar a funcionar normalmente
        SceneManager.LoadScene(0);// carrega a cena do menu principal, que é a primeira cena do jogo (índice 0)
    }
}
