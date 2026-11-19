using UnityEngine;

public class moeda : MonoBehaviour
{
    private float moedas = 0f;// variavel das moedas coletadas, inicia com 0
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))//compara a tag "Player" para realizar umção quando o player colidir com a moeda
        {
            moedas++;// soma as moedas coletadas
            Destroy(gameObject);// destroi o objeto
        }
    }
}
