using UnityEngine;
using UnityEngine.SceneManagement; // para mudar de cena

public class MenuController : MonoBehaviour
{
    // Função para carregar a cena principal do jogo
    public void StartGame()
    {
        SceneManager.LoadScene("Fase");
    }

    }
