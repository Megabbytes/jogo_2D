using UnityEngine;

public class CameraF_Vini : MonoBehaviour
{
    public Transform alvo;
    public Vector3 distancia = new Vector3(0f, 0f, -10f);// Variável pública do tipo Vector3 que define a distância da câmera em relação ao alvo.
    public bool movimentosuave = true;// Variável pública do tipo bool que indica se a câmera deve se mover suavemente em direção ao alvo ou não. 
    public float velocidade = 5f;// Variável pública do tipo float que define a velocidade de movimento da câmera quando movimentosuave é verdadeiro.

    private void LateUpdate()
    {
        Vector3 posicaoDesejada = alvo.position + distancia;// Calcula a posição desejada da câmera somando a posição do alvo (alvo.position) com a distância definida (distancia). 

        if (movimentosuave)// Verifica se a variável movimentosuave é verdadeira. Se for, a câmera se moverá suavemente em direção à posição desejada usando interpolação linear (Lerp)
        {
            transform.position = Vector3.Lerp(transform.position, posicaoDesejada, velocidade * Time.deltaTime);// Atualiza a posição da câmera.
        }
        else
        {
            transform.position = posicaoDesejada;// Se movimentosuave for falso, a posição da câmera é atualizada instantaneamente para a posição desejada (posicaoDesejada) sem suavização.
        }
    }
}
