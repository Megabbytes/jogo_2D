using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target; // variavel privada que pega a posição do player
    [SerializeField] private float smoothSpeed = 5f;// veialvelque define a suavidade do movimento da camera
    [SerializeField] private Vector3 offset = new Vector3(0f, 2f, -5f); // variavel que define o deslocamento da camera em relação ao player

    private void LateUpdate()
    {
        if (target == null)// verifica se o alvo que esta sendo seguido e nulo
            return;// retorna a função caso seja nula

        Vector3 desiredPosition = target.position + offset; // calcula a posição da camera com base na posição do player

        transform.position = Vector3.Lerp(transform.position,desiredPosition,smoothSpeed * Time.deltaTime);// atualiza a posição da camera com base na posição desejada
    }
}
