using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target; // Variável privada do tipo Transform que representa o alvo que a câmera seguirá. Essa variável é marcada com [SerializeField] para que possa ser configurada no Inspector do Unity, permitindo que você arraste e solte o objeto que deseja que a câmera siga. O Transform contém informações sobre a posição, rotação e escala do objeto, e será usado para determinar a posição desejada da câmera em relação ao alvo.
    [SerializeField] private float smoothSpeed = 5f; // Variável privada do tipo float que define a velocidade de suavização da câmera ao seguir o alvo. Essa variável é marcada com [SerializeField] para que possa ser configurada no Inspector do Unity, permitindo que você ajuste a rapidez com que a câmera se move em direção à posição desejada. O valor inicial é 5, mas pode ser ajustado para aumentar ou diminuir a suavidade do movimento da câmera.
    [SerializeField] private Vector3 offset = new Vector3(0f, 2f, -5f); // Variável privada do tipo Vector3 que define o deslocamento da câmera em relação ao alvo. Essa variável é marcada com [SerializeField] para que possa ser configurada no Inspector do Unity, permitindo que você ajuste a posição da câmera em relação ao alvo. O valor inicial é (0, 2, -5), o que significa que a câmera estará posicionada 2 unidades acima e 5 unidades atrás do alvo, mas pode ser ajustado para alterar a perspectiva da câmera.

    private void LateUpdate()
    {
        if (target == null)// Verifica se o alvo (target) é nulo. Se for nulo, significa que não há um objeto para a câmera seguir, então a função retorna imediatamente e não executa o restante do código. Isso evita erros de referência nula que poderiam ocorrer se tentássemos acessar a posição de um alvo inexistente.
            return;// Retorna da função LateUpdate() sem executar o restante do código, garantindo que a câmera não tente seguir um alvo inexistente e evitando possíveis erros de referência nula.

        Vector3 desiredPosition = target.position + offset; // Calcula a posição desejada da câmera somando a posição do alvo (target.position) com o deslocamento definido (offset). Isso determina onde a câmera deve estar em relação ao alvo, levando em consideração o deslocamento configurado no Inspector do Unity.

        transform.position = Vector3.Lerp(
            transform.position,
            desiredPosition,
            smoothSpeed * Time.deltaTime
        );// Atualiza a posição da câmera usando interpolação linear (Lerp) entre a posição atual da câmera (transform.position) e a posição desejada (desiredPosition). A interpolação é feita com base na velocidade de suavização (smoothSpeed) multiplicada pelo tempo delta (Time.deltaTime), garantindo que o movimento da câmera seja suave e consistente, independentemente da taxa de quadros do jogo.
    }
}
