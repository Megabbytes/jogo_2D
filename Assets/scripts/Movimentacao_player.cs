using UnityEngine;

public class Movimentacao_player : MonoBehaviour
{
    public float speed = 5f;
    public float horizontal;
    void Start()
    {
        
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * horizontal * speed * Time.deltaTime;
    }
}   
