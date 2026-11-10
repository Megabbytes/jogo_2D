using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScene : MonoBehaviour
{
    public GameObject painelPause;
    public GameObject painelGameOver;

    bool Pausado = false;
    bool jogoAcabou = false;
    void Start()
    {
        painelPause.SetActive(false);
        painelGameOver.SetActive(false);
    }
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape))
      {
            if(Pausado)
            {
                Continuar();
            }
            else
            {
                Pausar();
            }
      }
    }
    public void Pausar()
    {
        if(jogoAcabou == false)
        {
            Pausado = true;
            painelPause.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void Continuar()
    {
        Pausado = false;
        painelPause.SetActive(false);
        Time.timeScale = 1f;
    }
    public void MostarGameOver()
    {
        jogoAcabou = true;
        painelGameOver.SetActive(true);
        Time.timeScale = 0f;
        
    }
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
