using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemColetavel : MonoBehaviour
{
    // Nome da próxima cena (fase) que será carregada
    public string proximaFase = "Fase2";  // Corrigido aqui

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Player"))
        {
            // Mensagem no console
            Debug.Log("Item coletado!");

            // Destroi o item
            Destroy(gameObject);

            // Carrega a próxima fase
            SceneManager.LoadScene(proximaFase);
        }
    }
}
