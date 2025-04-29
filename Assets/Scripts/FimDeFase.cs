using UnityEngine;
using UnityEngine.SceneManagement;

public class FimDeFase : MonoBehaviour
{
    public GameObject painelFimDeFase; // arraste o painel aqui no Inspector

    void Start()
    {
        painelFimDeFase.SetActive(false); // garante que começa desativado
    }

    public void ConcluirFase()
    {
        painelFimDeFase.SetActive(true); // mostra o painel
        Time.timeScale = 0f; // pausa o jogo (opcional)
    }

    public void ProximaFase()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Fase2"); // troque pelo nome exato da Fase 2
    }

    public void SairParaMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuInicial"); // troque pelo nome exato do seu menu
    }
}
