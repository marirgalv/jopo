using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class CameraSegue : MonoBehaviour
{
    public Transform player;
    public float minX, maxX;
    public float timeLerp;

    private void FixerUpdate()
    {
        Vector3 newPosition = player.position + new Vector3(0,0, -10);
        newPosition.y = 0.1f;
        transform.position = newPosition;
        transform.position = Vector3.Lerp(transform.position, newPosition,timeLerp);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y, transform.position.z);
    }
}*/


public class CameraSegue : MonoBehaviour
{
    // Referência ao objeto que a câmera vai seguir
    public Transform Player;

    // Offset da câmera em relação ao alvo (posição relativa)
    public Vector3 offset;

    // Sensibilidade de suavização do movimento da câmera
    public float suavizacao = 0.125f;

    void FixedUpdate()
    {
        // Calcula a posição desejada com base na posição do alvo e no offset
        Vector3 posicaoDesejada = Player.position + offset;

        // Suaviza a transição entre a posição atual da câmera e a posição desejada
        Vector3 posicaoSuavizada = Vector3.Lerp(transform.position, posicaoDesejada, suavizacao);

        // Atualiza a posição da câmera
        transform.position = posicaoSuavizada;

        // Opcional: Manter a câmera sempre olhando para o alvo
        transform.LookAt(Player);
    }
}

