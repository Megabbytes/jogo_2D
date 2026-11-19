using System.Diagnostics;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    private float Segundos = 0f;// variavel dos segundos
    private float Minutos = 0f;// variavel dos minutos
    private bool finished = false;// variavel finished é usada para verificar se o cronometro deve parar de contar ou não
    void Start()
    {
        finished = false;// inicia o cronometro como não finalizado
    }

    private void OnCollisionEnter2D(Collision2D collision)// Quando o player colidir com outro objeto, essa função é chamada
    {
        if (collision.gameObject.CompareTag("Final"))//verifica se o objeto com o qual o player colidiu tem a tag "Final"
        {
            finished = true;// mostra que o cronometro deve parar de contar
            print("Tempo total: " + Minutos + " minutos e " + Segundos + " segundos.");// imprime o tempo total no console  
        }
        

    }

    void Update()
    {
        if (finished == false)// verifica se o cronometro deve continuar contando
        {
            Segundos += Time.deltaTime;// adiciona o tempo decorrido desde o último frame aos segundos

            if (Segundos >= 60f)// verifica se o tempo em segundos é maior ou igual a 60
            {
                Minutos += 1f;// adiciona 1 ao tempo em minutos
                Segundos -= 60f;// subtrai 60 do tempo em segundos para reiniciar a contagem de segundos
            }

            print($"Minutos: { Minutos:F0}" + $" Segundos: { Segundos:F1}");// imprime o tempo decorrido no console, com 0 casas decimais para os minutos e 1 casa decimal para os segundos
        }
       
    }
    
}
