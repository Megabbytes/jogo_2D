using System.Diagnostics;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    private float Segundos = 0f;
    private float Minutos = 0f;
    private bool finished = false;
    void Start()
    {
        finished = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            finished = true;
            print("Tempo total: " + Minutos + " minutos y " + Segundos + " segundos.");
        }
    }

    void Update()
    {
        if (finished == false)
        {
            Segundos += Time.deltaTime;

            if (Segundos >= 60f)
            {
                Minutos += 1f;
                Segundos -= 60f;
            }
            print("Minutos: " + Minutos + " Segundos: " + Segundos);

        }
       
    }
    
}
